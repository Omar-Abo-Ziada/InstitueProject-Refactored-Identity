using System.ComponentModel.DataAnnotations;

namespace InstitueProject.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage = "User name is required .")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Adress is required .")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Role is required .")]
        public string? Role { get; set; }
        [Required(ErrorMessage = "PassWord is required .")]

        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "ConfirmPassWord is required .")]
        [DataType(DataType.Password)]
        [Compare(nameof(PassWord))]
        [RegularExpression(@"^.{6,}$", ErrorMessage = "Password must be at least 6 characters long.")]
        public string ConfirmPassWord { get; set; }
    }
}
