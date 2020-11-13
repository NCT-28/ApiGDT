using System;
using System.Collections.Generic;
using System.Text;

namespace Source.source_model_base
{
    interface IAuditEntity<T>
    {
        T getCreatedBy();
        DateTime getCreatedDate();

        T getUpdatedBy();
        DateTime getUpdatedDate();
    }
}
