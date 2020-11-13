using System;
using System.Collections.Generic;
using System.Text;

namespace Source.source_model_base
{
    interface IDescriptionEntity<T> : IIdentifierEntity<T>
    {
        string getDescription();
        void setDescription(string description);
    }
}
