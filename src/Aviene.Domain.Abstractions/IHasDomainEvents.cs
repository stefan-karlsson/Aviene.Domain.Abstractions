using Aviene.Domain.Abstractions.Events;
using JetBrains.Annotations;

namespace Aviene.Domain.Abstractions;

/// <summary>
///   Represents an entity that contains one or more domain events.
/// </summary>
[PublicAPI]
public interface IHasDomainEvents
{
  /// <summary>
  ///   Gets the collection of domain events associated with the entity.
  /// </summary>
  IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
}
