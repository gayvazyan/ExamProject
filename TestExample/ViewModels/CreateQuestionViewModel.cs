using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestExample.ViewModels
{
    public class CreateQuestionViewModel
    {
        [Required(ErrorMessage = "Հարցի հերթական համարը մուտքագրված չէ")]
        [Display(Name = "Հարցի հերթական համարը")]
        public int QId { get; set; }
        [Required(ErrorMessage = "Հարցի տեքստը մուտքագրված չէ")]
        [Display(Name = "Տեքստ")]
        public string QuestionContent { get; set; }

       
    }
}
