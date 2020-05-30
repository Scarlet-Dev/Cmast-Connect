using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMASTConnect.DTO;

namespace CMASTConnect.DTO.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string Username { get; }

        public string EmailAddress { get; set; }

        public string Password { get; set;  }

        public DateTime PasswordExpiration { get; set; }

        public string UserType { get; set; }

        public List<UserPermissions> Permissions { get; }

        public DateTime AccountExpiration { get; set; }
    }
}
