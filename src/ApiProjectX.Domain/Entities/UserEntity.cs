using System;

namespace ApiProjectX.Domain.Entities
{
    public class UserEntity : BaseEntity
    {

        public string UserName { get; set; }

        public string UserNick { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        public string UserBirth { get; set; }

        public Guid? AcessTypeId { get; set; }
        public AcessTypeEntity AcessType { get; set; }
        


    }
}
