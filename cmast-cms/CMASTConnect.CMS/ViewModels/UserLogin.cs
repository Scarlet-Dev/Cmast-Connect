using CMASTConnect.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMASTConnect.CMS.ViewModels
{
    public class UserLogin
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public List<UserClaims> UserClaim { get; set; }
    }
}
