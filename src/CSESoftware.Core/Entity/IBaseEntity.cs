using System;

namespace CSESoftware.Core.Entity
{
    public interface IBaseEntity
    {
        object Id { get; set; }
        bool IsActive { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }

    public interface IBaseEntity<T> : IBaseEntity
    {
        new T Id { get; set; }
    }
}