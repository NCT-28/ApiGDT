using Source.source_model_base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Source.source_entity_base
{
    public abstract class AuditEntity<T> : IAuditEntity<T>
    {
        public T cratedBy { get; set; }
        public DateTime createdDate { get; set; }
        public T updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public abstract T getCreatedBy();
        public abstract DateTime getCreatedDate();
        public abstract T getUpdatedBy();
        public abstract DateTime getUpdatedDate();
    }
}
