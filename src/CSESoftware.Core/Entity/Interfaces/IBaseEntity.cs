namespace CSESoftware.Core.Entity
{
    public interface IBaseEntity : IActiveEntity, IModifiedEntity
    {
    }

    public interface IBaseEntity<T> : IBaseEntity
    {
        new T Id { get; set; }
    }
}