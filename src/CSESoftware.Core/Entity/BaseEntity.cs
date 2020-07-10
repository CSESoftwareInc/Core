using System;

namespace CSESoftware.Core.Entity
{
    public abstract class BaseEntity<T> : EntityWithId<T>, IBaseEntity<T>
    {
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public override void CreateSetup()
        {
            IsActive = true;
            CreatedDate = DateTime.UtcNow;
            ModifiedDate = DateTime.UtcNow;
            base.CreateSetup();
        }

        public override void UpdateSetup()
        {
            ModifiedDate = DateTime.UtcNow;
            base.UpdateSetup();
        }
    }
}
