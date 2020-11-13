using Source.source_entity_base;
using System;

namespace APIGDTVietNam.Models
{
    public class AccountDetails:  BaseEntity{
        public string about;
        public string  name { get; set; }
        public string  email { get; set; }
        public string  phoneNumer { get; set; }

        public override string getCreatedBy()
        {
            throw new NotImplementedException();
        }

        public override DateTime getCreatedDate()
        {
            throw new NotImplementedException();
        }

        public override string getUpdatedBy()
        {
            throw new NotImplementedException();
        }

        public override DateTime getUpdatedDate()
        {
            throw new NotImplementedException();
        }

        public override int getUuid()
        {
            throw new NotImplementedException();
        }
    }
    
}