using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Areas.Core.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Display(Name ="آدرس ایمیل")]
        [Required(ErrorMessage = "{0} مورد نیاز است.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
