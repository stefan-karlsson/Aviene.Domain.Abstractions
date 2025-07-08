using JetBrains.Annotations;

namespace Aviene.Domain.Abstractions;

/// <summary>
/// Marker interface to indicate that an entity is the aggregate root in the domain model.
/// Aggregate roots are entry points to aggregate boundaries and are responsible for enforcing consistency within the aggregate.
/// </summary>
[PublicAPI]
public interface IAggregateRoot;

