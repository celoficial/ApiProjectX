using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Entities
{
    public class UserEntity : BaseEntity
    {

        public string UserName { get; set; }

        public string UserNick { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        public string UserBirth { get; set; }

        

    }
}
