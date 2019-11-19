using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestExample.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Էլ. հասցեն մուտքագրված չէ")]
        [Display(Name = "Էլ. հասցե")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Գաղտնաբառը մուտքագրված չէ")]
        [Display(Name = "Գաղտնաբառ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Հիշել տվյալները")]
        public bool RememberMe { get; set; }
    }
}
