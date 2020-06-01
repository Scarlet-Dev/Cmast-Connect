using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CMASTConnect.CMS.ViewModels.UserVM
{
    public class UserLogin
    {
        [Required(ErrorMessage = "")]
        public string Username { get; set; }

        [Required(ErrorMessage = "")]
        [DataType(DataType.Password)]
        [PasswordPropertyText]
        public string Password { get; set; }

        public bool StayLoggedIn { get; set; }
    }
}
