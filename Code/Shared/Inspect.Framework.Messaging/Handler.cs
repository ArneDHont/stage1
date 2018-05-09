using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Inspect.Framework.Messaging
{
    /// <summary>
    /// Helper class that manage the handlers registrations.
    /// </summary>
    internal class Handler
    {
        private delegate void HandleMessageDelegate(object handler, object message);

        private delegate Task HandleAsyncMessageDelegate(object handler, object message, CancellationToken cancellationToken);

        private readonly object mToken;

        private readonly WeakReference mReferenceToHandler;

        private readonly Dictionary<Type, MethodInfo> mSupportedHandlers = new Dictionary<Type, MethodInfo>();

        private readonly Dictionary<Type, MethodInfo> mSupportedAsyncHandlers = new Dictionary<Type, MethodInfo>();

        private readonly Dictionary<Type, HandleMessageDelegate> mSupportedHandleDelegates = new Dictionary<Type, HandleMessageDelegate>();

        private readonly Dictionary<Type, HandleAsyncMessageDelegate> mSupportedHandleAsyncDelegates = new Dictionary<Type, HandleAsyncMessageDelegate>();

        /// <summary>
        /// Determines whether the handlers is dead or alive (weak reference).
        /// </summary>
        public bool IsDead
        {
            get
            {
                return mReferenceToHandler.Target == null;
            }
        }

        /// <summary>
        /// Create a new instance of the <see cref="Handler"/> class.
        /// </summary>
        /// <param name="handler">The handler</param>
        /// <param name="token">Optional: The token</param>
        public Handler(object handler, object token = null)
        {
            mReferenceToHandler = new WeakReference(handler);
            mToken = token;

            var interfaces = handler.GetType().GetInterfaces()
                .Where(x => typeof(IHandle).IsAssignableFrom(x) && x.IsGenericType);

            foreach (var @interface in interfaces)
            {
                Type type = @interface.GetGenericArguments()[0];
                MethodInfo method = @interface.GetMethod("Handle", new Type[] { type });

                if (method != null)
                {
                    mSupportedHandlers[type] = method;
                }
                else
                {
                    method = @interface.GetMethod("HandleAsync", new Type[] { type, typeof(CancellationToken) });
                    if (method != null)
                    {
                        mSupportedAsyncHandlers[type] = method;
                    }

                }
            }
        }

        /// <summary>
        /// Determines whether the handler matches the specified instance and token.
        /// </summary>
        /// <param name="instance">The instance</param>
        /// <param name="token">The token</param>
        /// <returns></returns>
        public bool Matches(object instance, object token = null)
        {
            return mReferenceToHandler.Target == instance && mToken == token;
        }

        /// <summary>
        /// Handles the specified message
        /// </summary>
        /// <typeparam name="TMessage">The type of message that needs to be handled.</typeparam>
        /// <param name="message">The message that needs to be handled.</param>
        /// <param name="token">The Token</param>
        /// <returns>True when the Handler is alive; otherwise fase</returns>
        public bool Handle<TMessage>(TMessage message, object token = null)
        {
            var target = mReferenceToHandler.Target;
            if (target == null)
            {
                return false;
            }

            if (mToken == token)
            {
                foreach (var pair in mSupportedHandlers)
                {
                    if (pair.Key.IsAssignableFrom(typeof(TMessage)))
                    {
                        if (!mSupportedHandleDelegates.ContainsKey(typeof(TMessage)))
                        {
                            Action<IHandle<TMessage>, TMessage> messageHandler = (Action<IHandle<TMessage>, TMessage>)Delegate.CreateDelegate(typeof(Action<IHandle<TMessage>, TMessage>), pair.Value);
                            mSupportedHandleDelegates[typeof(TMessage)] = (object h, object m) => messageHandler((IHandle<TMessage>)h, (TMessage)m);
                        }
                        mSupportedHandleDelegates[typeof(TMessage)].Invoke(target, message);
                    }
                }
            }

            return true;
        }

        public async Task<bool> HandleAsync<TMessage>(TMessage message, object token, CancellationToken cancellationToken)
        {
            var target = mReferenceToHandler.Target;
            if (target == null)
            {
                return false;
            }

            if (mToken == token)
            {
                foreach (var pair in mSupportedAsyncHandlers)
                {
                    if (pair.Key.IsAssignableFrom(typeof(TMessage)))
                    {
                        if (!mSupportedHandleAsyncDelegates.ContainsKey(typeof(TMessage)))
                        {
                            var messageHandler = (Func<IHandleAsync<TMessage>, TMessage, CancellationToken, Task>)Delegate.CreateDelegate(typeof(Func<IHandleAsync<TMessage>, TMessage, CancellationToken, Task>), pair.Value);
                            mSupportedHandleAsyncDelegates[typeof(TMessage)] = (object h, object m, CancellationToken t) => messageHandler((IHandleAsync<TMessage>)h, (TMessage)m, t);
                        }
                        await mSupportedHandleAsyncDelegates[typeof(TMessage)](target, message, cancellationToken);
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Determines whether the handler can handle the specified message type and token.
        /// </summary>
        /// <param name="messageType">The type of message</param>
        /// <param name="token">The token</param>
        /// <returns></returns>
        public bool Handles(Type messageType, object token = null)
        {
            return (mSupportedHandlers.Any(x => x.Key.IsAssignableFrom(messageType))
                || mSupportedAsyncHandlers.Any(x => x.Key.IsAssignableFrom(messageType))) && mToken == token;
        }
    }
}