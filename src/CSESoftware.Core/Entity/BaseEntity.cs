﻿namespace CSESoftware.Core.Entity
{
    public abstract class BaseEntity<T> : ModifiedEntity<T>, IBaseEntity<T>
    {
        public bool IsActive { get; set; } = true;
    }
}