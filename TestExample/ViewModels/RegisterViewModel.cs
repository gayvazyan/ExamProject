using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestExample.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Անունը մուտքագրված չէ")]
        [Display(Name = "Անուն")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Ազգանունը մուտքագրված չէ")]
        [Display(Name = "Ազգանուն")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Հայրանունը մուտքագրված չէ")]
        [Display(Name = "Հայրանուն")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Անձնագիրը մուտքագրված չէ")]
        [Display(Name = "Անձնագիր")]
        public string Passport { get; set; }

        [Required(ErrorMessage = "Հեռախոսահամարը մուտքագրված չէ")]
        [Display(Name = "Հեռախոսահամար")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Էլ. հասցեն մուտքագրված չէ")]
        [Display(Name = "Էլ. հասցե")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Գաղտնաբառը մուտքագրված չէ")]
        [Display(Name = "Գաղտնաբառ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Կրկնել գաղտնաբառը մուտքագրված չէ")]
        [DataType(DataType.Password)]
        [Display(Name = "Կրկնել գաղտնաբառը")]
        [Compare("Password",
            ErrorMessage = " Մուտքագրված <Գաղտնաբառ> և <Կրկնել գաղտնաբառը> չէն համընկնում")]
        public string ConfirmPassword { get; set; }

    }
}
