using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    /// <summary>
    /// Enables loosly-coupled publication of - and subscription to - events.
    /// </summary>
    public class Messenger : IMessenger
    {
        private static IMessenger sDefaultInstance;

        private static object sSyncRoot = new object();

        private readonly List<Handler> mHandlerList = new List<Handler>();

        private object mSyncRoot = new object();

        /// <summary>
        /// Gets the Messenger's default instance, allowing to register and send messages in a static manner.
        /// </summary>
        public static IMessenger Default
        {
            get
            {
                if (sDefaultInstance == null)
                {
                    lock (sSyncRoot)
                    {
                        if (sDefaultInstance == null)
                        {
                            sDefaultInstance = new Messenger();
                        }
                    }
                }

                return sDefaultInstance;
            }
        }

        /// <summary>
        /// Determines whether the <see cref="IMessenger"/> has a handler for the specified message type.
        /// </summary>
        /// <param name="messageType">The type of the message.</param>
        /// <returns>True when a handler exists; otherwise false</returns>
        public bool HandlerExistsFor(Type messageType)
        {
            return mHandlerList.Any(x => x.Handles(messageType) && !x.IsDead);
        }

        /// <summary>
        /// Determines whether the <see cref="IMessenger"/> has a handler for the specified message type and token.
        /// </summary>
        /// <param name="messageType">The type of the message.</param>
        /// <param name="token">The token.</param>
        /// <returns>True when a handler exists; otherwise false</returns>
        public bool HandlerExistsFor(Type messageType, object token)
        {
            return mHandlerList.Any(x => x.Handles(messageType, token) && !x.IsDead);
        }

        /// <summary>
        /// Publish a message.
        /// </summary>
        /// <typeparam name="TMessage">Type type of message.</typeparam>
        /// <param name="message">The message instance.</param>
        /// <param name="marshal">Allows the publioscher to provide a custom thread marshaller for the message publication.</param>
        public void Publish<TMessage>(TMessage message, Action<Action> marschal) where TMessage : class
        {
            Publish(message, null, marschal);
        }

        /// <summary>
        /// Publish a message with a token.
        /// </summary>
        /// <typeparam name="TMessage">Type type of message.</typeparam>
        /// <param name="message">The message instance.</param>
        /// <param name="token">The token instance.</param>
        /// <param name="marshal">Allows the publioscher to provide a custom thread marshaller for the message publication.</param>
        public void Publish<TMessage>(TMessage message, object token, Action<Action> marschal) where TMessage : class
        {
            if (marschal == null)
            {
                throw new ArgumentNullException(nameof(marschal));
            }

            Handler[] handlersToNotify;
            lock (mSyncRoot)
            {
                handlersToNotify = mHandlerList.ToArray();
            }

            marschal(() =>
            {
                List<Handler> deadHandlers = handlersToNotify.Where(x => !x.Handle(message, token)).ToList();
                if (deadHandlers.Any())
                {
                    lock (mSyncRoot)
                    {
                        deadHandlers.ForEach(x => mHandlerList.Remove(x));
                    }
                }
            });
        }

        /// <summary>
        /// Publish a message with a token.
        /// </summary>
        /// <typeparam name="TMessage">Type type of message.</typeparam>
        /// <param name="message">The message instance.</param>
        /// <param name="token">The token instance.</param>
        public async Task PublishAsync<TMessage>(TMessage message, object token, CancellationToken cancellationToken) where TMessage : class
        {
            Handler[] handlersToNotify;
            lock (mSyncRoot)
            {
                handlersToNotify = mHandlerList.ToArray();
            }

            List<Handler> deadHandlers = new List<Handler>();
            foreach(var handler in handlersToNotify)
            {
                bool alive = await handler.HandleAsync(message, token, cancellationToken).ConfigureAwait(false);
                if (!alive)
                {
                    deadHandlers.Add(handler);
                }
            }

            if (deadHandlers.Any())
            {
                lock (mSyncRoot)
                {
                    deadHandlers.ForEach(x => mHandlerList.Remove(x));
                }
            }
        }

        /// <summary>
        /// Publish a message with a token.
        /// </summary>
        /// <typeparam name="TMessage">Type type of message.</typeparam>
        /// <param name="message">The message instance.</param>
        /// <param name="token">The token instance.</param>
        public Task PublishAsync<TMessage>(TMessage message, CancellationToken cancellationToken) where TMessage : class
        {
            return PublishAsync(message, null, cancellationToken);
        }

        /// <summary>
        /// Subscribes a message handler.
        /// </summary>
        /// <param name="subscriber">The handler to subscribe.</param>
        public void Subscribe(object subscriber)
        {
            Subscribe(subscriber, null);
        }

        /// <summary>
        /// Subscribes a message handler for the specified token.
        /// </summary>
        /// <param name="subscriber">The handler to subscribe.</param>
        /// <param name="token">The token</param>
        public void Subscribe(object subscriber, object token)
        {
            if (subscriber == null)
            {
                throw new ArgumentNullException(nameof(subscriber));
            }

            lock (mSyncRoot)
            {
                if (mHandlerList.Any(x => x.Matches(subscriber, token)))
                {
                    return;
                }
                mHandlerList.Add(new Handler(subscriber, token));
            }
        }

        /// <summary>
        /// Unsubscribes a message handler from the <see cref="IMessenger"/>.
        /// </summary>
        /// <param name="subscriber">The handler to unsubscribe.</param>
        public void Unsubscribe(object subscriber)
        {
            Unsubscribe(subscriber, null);
        }

        /// <summary>
        /// Unsubscribes a message handler from the <see cref="IMessenger"/> for the specified token.
        /// </summary>
        /// <param name="subscriber">The handler to unsubscribe.</param>
        /// <param name="token">The token</param>
        public void Unsubscribe(object subscriber, object token)
        {
            if (subscriber == null)
            {
                throw new ArgumentNullException(nameof(subscriber));
            }

            lock (mSyncRoot)
            {
                var found = mHandlerList.FirstOrDefault(x => x.Matches(subscriber, token));
                if (found != null)
                {
                    mHandlerList.Remove(found);
                }
            }
        }
    }
}