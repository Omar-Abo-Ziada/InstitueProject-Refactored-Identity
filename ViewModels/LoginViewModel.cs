using System.ComponentModel.DataAnnotations;

namespace InstitueProject.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "UserName is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "PassWord is required.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^.{6,}$", ErrorMessage = "Password must be at least 6 characters long.")]
        public string PassWord { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
