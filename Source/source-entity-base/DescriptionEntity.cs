using Source.source_model_base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Source.source_entity_base
{
    public abstract class DescriptionEntity : IdentifierEntity, IDescriptionEntity<int>
    {
        private string description { get; set; }
        public abstract string getDescription();
        public abstract void setDescription(string description);
    }
}
