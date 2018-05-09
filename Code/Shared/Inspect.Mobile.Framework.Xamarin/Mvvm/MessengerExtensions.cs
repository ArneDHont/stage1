namespace Inspect.Mobile.Framework.Xamarin.Mvvm
{
    /// <summary>
    /// Extensions for <see cref="IMessenger"/>.
    /// </summary>
    public static class MessengerExtensions
    {
        /// <summary>
        /// Publish a message on the current thread.
        /// </summary>
        /// <typeparam name="TMessage">The type of the message</typeparam>
        /// <param name="messenger">The messenger instance</param>
        /// <param name="message">The message instance</param>
        public static void PublishOnCurrentThread<TMessage>(this IMessenger messenger, TMessage message) where TMessage : class
        {
            messenger.Publish(message, action => action());
        }

        /// <summary>
        /// Publish a message with a token on the current thread.
        /// </summary>
        /// <typeparam name="TMessage">The type of the message.</typeparam>
        /// <param name="messenger">The messenger instance.</param>
        /// <param name="message">The message instance.</param>
        /// <param name="token">The token.</param>
        public static void PublishOnCurrentThread<TMessage>(this IMessenger messenger, TMessage message, object token) where TMessage : class
        {
            messenger.Publish(message, token, action => action());
        }
    }
}