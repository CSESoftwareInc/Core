using System;

namespace CSESoftware.Core.Entity
{
    public interface IModifiedEntity : IEntityWithId
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }

    public interface IModifiedEntity<T> : IModifiedEntity
    {
        new T Id { get; set; }
    }
}