using Source.source_enums_base;
using Source.source_model_base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Source.source_entity_base
{
    public abstract class PeopleDetailsEntity : BaseEntity, IPeopleDetailsEntity<int>
    {
        public string name { get; set; }    
        public string  email { get; set; }  
        public string  phoneNumber { get; set; }
        public Gender gender { get; set; }
        public DateTime birthday { get; set; }
        public string  identityCard { get; set; }
        public string locationProvided { get; set; }
        public abstract DateTime getBirthday();
        public abstract DateTime getDateOfSupply();
        public abstract string getEmail();
        public abstract Gender getGender();
        public abstract string getIdentityCard();
        public abstract string getLocationProvided();
        public abstract string getName();
        public abstract string getPhoneNumber();
        public abstract void setBirthday(DateTime birthday);
        public abstract void setDateOfSupply(DateTime dateOfSupply);
        public abstract void setEmail(string email);
        public abstract void setGender(Gender gender);
        public abstract void setIdentityCard(string identityCard);
        public abstract void setLocationProvided(string locationProvided);
        public abstract void setName(string name);
        public abstract void setPhoneNumber(string phoneNumber);
    }
}
