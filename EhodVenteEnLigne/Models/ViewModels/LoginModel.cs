using System.ComponentModel.DataAnnotations;

namespace EhodBoutiqueEnLigne.Models.ViewModels
{
    public class LoginModel
    {

        [Required(ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.LoginError), ErrorMessageResourceName = "ErrorMissingName")]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.LoginError), ErrorMessageResourceName = "ErrorMissingPassword")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}