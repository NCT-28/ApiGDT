using System;
using System.Collections.Generic;
using System.Text;

namespace Source.source_model_base
{
    interface IIdentifierEntity<T> : INaturalIdEntity<T>
    {
        string getName();
        void setName(string name);
    }
}
