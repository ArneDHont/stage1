using System.Threading;
using System.Threading.Tasks;

namespace Inspect.Framework.Messaging
{
    /// <summary>
    /// Marker interface for classes that subscribe to messages
    /// </summary>
    public interface IHandle
    {
    }

    /// <summary>
    /// Interface for a class which can handle a specific message.
    /// </summary>
    /// <typeparam name="TMessage">The type of message to handle</typeparam>
    public interface IHandle<TMessage> : IHandle
    {
        /// <summary>
        /// Handles the message
        /// </summary>
        /// <param name="message">The message.</param>
        void Handle(TMessage message);
    }

    /// <summary>
    /// Interface for a class which can handle a specific message.
    /// </summary>
    /// <typeparam name="TMessage">The type of message to handle</typeparam>
    public interface IHandleAsync<TMessage> : IHandle
    {
        Task HandleAsync(TMessage message, CancellationToken cancellationToken);
    }
}