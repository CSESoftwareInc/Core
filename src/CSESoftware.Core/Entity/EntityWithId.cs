namespace CSESoftware.Core.Entity
{
    public abstract class EntityWithId<T> : Entity, IEntityWithId<T>
    {
        public T Id { get; set; }

        public override void CreateSetup()
        {
            base.CreateSetup();
        }

        public override void UpdateSetup()
        {
            base.UpdateSetup();
        }
    }
}
