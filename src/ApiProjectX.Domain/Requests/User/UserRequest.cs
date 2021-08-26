using ApiProjectX.Domain.Entities;
using System;

namespace ApiProjectX.Domain.Requests
{
    public class UserRequest
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserNick { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserBirth { get; set; }
        public AcessTypeEntity AcessType { get; set; }
    }
}
