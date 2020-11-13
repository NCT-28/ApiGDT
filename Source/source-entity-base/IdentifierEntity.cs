using Source.source_model_base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Source.source_entity_base
{
    public abstract class IdentifierEntity : NaturalIdEntity, IIdentifierEntity<int>
    {
        private string name { get; set; }
        public abstract string getName();
        public abstract void setName(string name);
    }
}
