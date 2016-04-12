using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace Lib.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Books> UserProfiles { get; set; }
    }

    [Table("UserProfile")]
    public class Books
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

    public class RegisterExternalLoginModel
    {
        [Required]
        [Display(Name = "Хэрэглэгчийн нэр")]
        public string UserName { get; set; }

        public string ExternalLoginData { get; set; }
    }

    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Хуучин нууц үг")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} доод тал нь {2} тэмдэгтээс урт байна.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Шинэ нууц үг")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Шинэ нууц үг дахин оруул")]
        [Compare("NewPassword", ErrorMessage = "Шинэ нууц үг, баталгаажуулах нууц үг таарахгүй байна.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "Хэрэглэгчийн нэр")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Нууц үг")]
        public string Password { get; set; }

        [Display(Name = "Намайг сана?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
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
        [Compare("Password", ErrorMessage = "Нууц үг таарахгүй байна.")]
        public string ConfirmPassword { get; set; }
    }

    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}
