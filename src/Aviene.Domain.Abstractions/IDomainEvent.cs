using JetBrains.Annotations;

namespace Aviene.Domain.Abstractions;

/// <summary>
/// Represents a domain event that signals a significant change or occurrence within the domain model.
/// </summary>
[PublicAPI]
public interface IDomainEvent
{
    /// <summary>
    /// Gets the timestamp indicating when the event occurred.
    /// </summary>
    DateTime OccurredAt { get; }
}