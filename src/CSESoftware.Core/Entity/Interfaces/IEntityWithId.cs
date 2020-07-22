namespace CSESoftware.Core.Entity
{
    public interface IEntityWithId<T> : IEntity
    {
        T Id { get; set; }
    }
}
