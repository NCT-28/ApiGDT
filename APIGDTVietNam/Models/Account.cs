using Source.source_entity_base;
using System;
using System.ComponentModel.DataAnnotations;

namespace APIGDTVietNam.Models
{
    public partial class Account : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string username { get; set; }
        [Required]
        [MaxLength(256)]
        public string password { get; set; }
        public string displayName { get; set; }
        public bool locked { get; set; }

        public bool enabled { get; set; }
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
