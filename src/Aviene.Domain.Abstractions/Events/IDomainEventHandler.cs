namespace Aviene.Domain.Abstractions.Events;

/// <summary>
///   Defines a handler for processing a specific type of domain event.
/// </summary>
/// <typeparam name="T">
///   The type of domain event to handle. Must implement <see cref="IDomainEvent" />.
/// </typeparam>
[PublicAPI]
public interface IDomainEventHandler<in T> where T : IDomainEvent
{
  /// <summary>
  ///   Handles the specified domain event asynchronously.
  /// </summary>
  /// <param name="domainEvent">The domain event instance to be processed.</param>
  /// <param name="cancellationToken">
  ///   A cancellation token that can be used to cancel the operation.
  /// </param>
  /// <returns>
  ///   A <see cref="Task" /> that represents the asynchronous operation.
  /// </returns>
  /// <exception cref="OperationCanceledException">
  ///   Thrown if the operation is canceled via the <paramref name="cancellationToken" />.
  /// </exception>
  Task Handle(T domainEvent, CancellationToken cancellationToken);
}
