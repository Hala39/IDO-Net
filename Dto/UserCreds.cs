using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dto
{
    public class UserCreds
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; }
    }
}