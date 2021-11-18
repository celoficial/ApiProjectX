using ApiProjectX.Domain.Entities;

namespace ApiProjectX.Domain.Requests.User
{
    public class UserRequest
    {
        public string UserName { get; set; }
        public string UserNick { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserBirth { get; set; }
        public AcessTypeEntity AcessType { get; set; }
    }
}
