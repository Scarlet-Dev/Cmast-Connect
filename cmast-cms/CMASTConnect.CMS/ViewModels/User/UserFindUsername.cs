using System.ComponentModel.DataAnnotations;

namespace CMASTConnect.CMS.ViewModels.UserVM
{
    public class UserFindUsername
    {
        [Required]
        public string UserEmail { get; }
    }
}
