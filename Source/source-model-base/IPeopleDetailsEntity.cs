using Source.source_enums_base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Source.source_model_base
{
    interface IPeopleDetailsEntity<T> : IBaseEntity<T>
    {
        string getName();

        void setName(string name);

        string getEmail();

        void setEmail(string email);

        string getPhoneNumber();

        void setPhoneNumber(string phoneNumber);

        Gender getGender();

        void setGender(Gender gender);

        DateTime getBirthday();

        void setBirthday(DateTime birthday);

        string getIdentityCard();

        void setIdentityCard(string identityCard);

        DateTime getDateOfSupply();

        void setDateOfSupply(DateTime dateOfSupply);

        string getLocationProvided();

        void setLocationProvided(string locationProvided);
    }
}
