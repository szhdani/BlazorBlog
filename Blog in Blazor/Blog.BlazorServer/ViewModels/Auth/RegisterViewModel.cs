using System.ComponentModel.DataAnnotations;

namespace Blog.BlazorServer.ViewModels.Auth
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [MinLength(2, ErrorMessage = "Username's minimum length is 2")]
        [MaxLength(15, ErrorMessage = "Username's maximum length is 15")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [Display(Name = "Email")]
        [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d-]+(\.[a-zA-Z\d-]+)*\.[a-zA-Z]{2,}$", ErrorMessage = "The E-mail address that you entered is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [MinLength(6, ErrorMessage = "Password's minimum length is 6")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password and Confirm password must be the same!")]
        public string ConfirmPassword { get; set; }
    }
}
