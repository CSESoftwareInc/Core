namespace CSESoftware.Core.Entity
{
    public interface IEntityWithId : IEntity
    {
        object Id { get; set; }
    }

    public interface IEntityWithId<T> : IEntityWithId
    {
        new T Id { get; set; }
    }
}