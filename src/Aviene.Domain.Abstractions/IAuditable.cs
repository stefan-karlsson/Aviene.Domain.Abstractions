namespace Aviene.Domain.Abstractions;

/// <summary>
///   Represents an auditable entity that tracks creation and modification metadata.
///   Useful for maintaining consistent auditing information across domain or persistence models.
/// </summary>
public interface IAuditable
{
  /// <summary>
  ///   Gets the timestamp of when the entity was created (in UTC).
  /// </summary>
  DateTimeOffset CreatedAt { get; }

  /// <summary>
  ///   Gets the identifier of the user or system that created the entity.
  /// </summary>
  string CreatedBy { get; }

  /// <summary>
  ///   Gets the timestamp of the last modification (in UTC), if any.
  /// </summary>
  DateTimeOffset? UpdatedAt { get; }

  /// <summary>
  ///   Gets the identifier of the user or system that last modified the entity, if any.
  /// </summary>
  string? UpdatedBy { get; }

  /// <summary>
  ///   Sets the creation audit metadata using the given time provider and optional creator ID.
  ///   Intended to be called only once when the entity is first persisted.
  /// </summary>
  /// <param name="timeProvider">Time provider for retrieving the current timestamp.</param>
  /// <param name="createdBy">Optional identifier of the creator (user or system).</param>
  void SetCreated(TimeProvider timeProvider, string? createdBy = null);

  /// <summary>
  ///   Sets the update audit metadata using the given time provider and optional modifier ID.
  ///   Should be called whenever the entity is modified.
  /// </summary>
  /// <param name="timeProvider">Time provider for retrieving the current timestamp.</param>
  /// <param name="updatedBy">Optional identifier of the modifier (user or system).</param>
  void SetUpdated(TimeProvider timeProvider, string? updatedBy = null);
}
