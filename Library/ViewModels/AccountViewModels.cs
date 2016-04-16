using System.ComponentModel.DataAnnotations;

namespace Itera.Fagdag.November.ViewModels 
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Хэрэглэгчийн нэр")]
        public string UserName { get; set; }

        [Required]
        public string LoginProvider { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Хуучин нууц үг")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} доод тал нь {2} тэмдэгтээс урт байна", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Шинэ нууц үг")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Нууц үг дахин оруулна уу")]
        [Compare("NewPassword", ErrorMessage = "Таны оруулсан шинэ нууц үг буруу байна.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Хэрэглэгчийн нэр")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Нууц үг")]
        public string Password { get; set; }

        [Display(Name = "Намайг сана ?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Хэрэглэгчийн нэр")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} доод тал нь {2} тэмдэгтээс урт байна.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Нууц үг")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Нууц үгээ дахин оруулна уу")]
        [Compare("Password", ErrorMessage = "Таны оруулсан шинэ нууц үг буруу байна.")]
        public string ConfirmPassword { get; set; }
    }
}