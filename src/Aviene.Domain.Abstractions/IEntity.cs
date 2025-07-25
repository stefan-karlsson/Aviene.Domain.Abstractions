using JetBrains.Annotations;

namespace Aviene.Domain.Abstractions;

/// <summary>
/// Marker interface for entities that use <see cref="Guid" /> as their primary key type.
/// </summary>
[PublicAPI]
public interface IEntity : IEntity<Guid>;

/// <summary>
/// Represents a domain entity with a primary key.
/// </summary>
/// <typeparam name="TPrimaryKey">
/// The type of the entity's unique identifier (e.g., <see cref="Guid" />, <see cref="int" />, <see cref="string" />, or a strongly-typed ID).
/// </typeparam>
public interface IEntity<out TPrimaryKey>
{
    /// <summary>
    /// Gets the unique identifier of the entity.
    /// </summary>
    TPrimaryKey Id { get; }
}

/// <summary>
/// Represents a domain entity that can be used with strongly-typed IDs, such as those generated by
/// <see href="https://github.com/vo-gen/Vogen">Vogen</see> or similar tools.
/// </summary>
/// <typeparam name="TEntity">
/// The concrete entity type that implements this interface (used for generic constraints).
/// </typeparam>
/// <typeparam name="TPrimaryKey">
/// The type of the entity's unique identifier.
/// </typeparam>
public interface IEntity<TEntity, out TPrimaryKey> where TEntity : IEntity<TEntity, TPrimaryKey>
{
    /// <summary>
    /// Gets the unique identifier of the entity.
    /// </summary>
    TPrimaryKey Id { get; }
}
