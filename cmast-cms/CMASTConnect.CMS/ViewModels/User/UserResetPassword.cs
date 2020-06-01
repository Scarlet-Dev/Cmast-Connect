using System.ComponentModel.DataAnnotations;

namespace CMASTConnect.CMS.ViewModels.UserVM
{
    public class UserResetPassword
    {
        [Required]
        public string Username { get; }

        [Required]
        public string ResetPassword { get; }

        [Required]
        public string ConfirmResetPassword { get; }
    }
}
