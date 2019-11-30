using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestExample.ViewModels
{
    public class CreateAnswerViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Պատասխանի տեքստը մուտքագրված չէ")]
        [Display(Name = "Պատասխանի տեքստ")]
        public string QuestionVariantContent { get; set; }
        [Required(ErrorMessage = "Պատասխանի տեսակը մուտքագրված չէ")]
        [Display(Name = "Պատասխանի տեսակը")]
        public bool CorrectAnswer { get; set; }
        [Required(ErrorMessage = "Հարցի համարը մուտքագրված չէ")]
        [Display(Name = "Հարցի համարը")]
        public int QuestionId { get; set; }
    }
}
