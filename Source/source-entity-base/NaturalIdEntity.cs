using Source.source_model_base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Source.source_entity_base
{
    public abstract class NaturalIdEntity : BaseEntity, INaturalIdEntity<int>
    {
        private string code { get; set; }
        public abstract string getCode();
        public abstract void setCode(string code);
    }
}
