using System;
using System.Threading;
using System.Threading.Tasks;

namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    /// <summary>
    /// Enables loosly-coupled publication of - and subscription to - events.
    /// </summary>
    public interface IMessenger
    {
        /// <summary>
        /// Determines whether the <see cref="IMessenger"/> has a handler for the specified message type.
        /// </summary>
        /// <param name="messageType">The type of the message.</param>
        /// <returns>True when a handler exists; otherwise false</returns>
        bool HandlerExistsFor(Type messageType);

        /// <summary>
        /// Determines whether the <see cref="IMessenger"/> has a handler for the specified message type and token.
        /// </summary>
        /// <param name="messageType">The type of the message.</param>
        /// <param name="token">The token.</param>
        /// <returns>True when a handler exists; otherwise false</returns>
        bool HandlerExistsFor(Type messageType, object token);

        /// <summary>
        /// Publish a message.
        /// </summary>
        /// <typeparam name="TMessage">Type type of message.</typeparam>
        /// <param name="message">The message instance.</param>
        /// <param name="marshal">Allows the publioscher to provide a custom thread marshaller for the message publication.</param>
        void Publish<TMessage>(TMessage message, Action<Action> marshal) where TMessage : class;

        /// <summary>
        /// Publish a message with a token.
        /// </summary>
        /// <typeparam name="TMessage">Type type of message.</typeparam>
        /// <param name="message">The message instance.</param>
        /// <param name="token">The token instance.</param>
        /// <param name="marshal">Allows the publioscher to provide a custom thread marshaller for the message publication.</param>
        void Publish<TMessage>(TMessage message, object token, Action<Action> marshal) where TMessage : class;

        /// <summary>
        /// Publish a message with a token.
        /// </summary>
        /// <typeparam name="TMessage">Type type of message.</typeparam>
        /// <param name="message">The message instance.</param>
        /// <param name="token">The token instance.</param>
        Task PublishAsync<TMessage>(TMessage message, object token, CancellationToken cancellationToken) where TMessage : class;

        /// <summary>
        /// Publish a message with a token.
        /// </summary>
        /// <typeparam name="TMessage">Type type of message.</typeparam>
        /// <param name="message">The message instance.</param>
        /// <param name="token">The token instance.</param>
        Task PublishAsync<TMessage>(TMessage message, CancellationToken cancellationToken) where TMessage : class;

        /// <summary>
        /// Subscribes a message handler.
        /// </summary>
        /// <param name="subscriber">The handler to subscribe.</param>
        void Subscribe(object subscriber);

        /// <summary>
        /// Subscribes a message handler for the specified token.
        /// </summary>
        /// <param name="subscriber">The handler to subscribe.</param>
        /// <param name="token">The token</param>
        void Subscribe(object subscriber, object token);

        /// <summary>
        /// Unsubscribes a message handler from the <see cref="IMessenger"/>.
        /// </summary>
        /// <param name="subscriber">The handler to unsubscribe.</param>
        void Unsubscribe(object subscriber);

        /// <summary>
        /// Unsubscribes a message handler from the <see cref="IMessenger"/> for the specified token.
        /// </summary>
        /// <param name="subscriber">The handler to unsubscribe.</param>
        /// <param name="token">The token</param>
        void Unsubscribe(object subscriber, object token);
    }
}