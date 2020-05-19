using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set;  }

        public List<UserClaims> Claims { get; }

        public DateTime ExpirationDate { get; set; }
    }
}
