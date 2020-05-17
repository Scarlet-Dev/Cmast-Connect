using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMASTConnect.DTO;

namespace CMASTConnect.DTO.Models
{
    public class User
    {
        public string Username { get; }
        public string Password { get; }
        public List<UserClaims> Claims { get; }
    }
}
