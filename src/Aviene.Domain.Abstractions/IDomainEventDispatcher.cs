using JetBrains.Annotations;

namespace Aviene.Domain.Abstractions;

/// <summary>
/// Defines a contract for dispatching domain events associated with entities.
/// </summary>
[PublicAPI]
public interface IDomainEventDispatcher
{
    /// <summary>
    /// Dispatches all domain events from the provided entities.
    /// </summary>
    /// <param name="entitiesWithEvents">
    /// A collection of entities that contain domain events to be dispatched.
    /// </param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DispatchEvent(IEnumerable<IHasDomainEvents> entitiesWithEvents);
}
