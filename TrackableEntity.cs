using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityAbstractions;

public abstract class TrackableEntity
{
    protected TrackableEntity()
    {
    }

    protected TrackableEntity(Guid? id)
    {
        Id = id;
    }

    public Guid? Id { get; init; }

    public override bool Equals(object? obj)
    {
        return obj is TrackableEntity @base && Id == @base.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }

    public static bool operator ==(TrackableEntity? one, object? other)
    {
        return one?.Equals(other) ?? false;
    }

    public static bool operator !=(TrackableEntity? one, object? other)
    {
        return !(one == other);
    }
}