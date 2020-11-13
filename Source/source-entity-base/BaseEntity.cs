using Source.source_model_base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Source.source_entity_base
{
    public abstract class BaseEntity : AuditEntity<string>, IBaseEntity<int>
    {
        [Key]
        public int uuid { get; set; }
        public abstract int getUuid();
    }
}
