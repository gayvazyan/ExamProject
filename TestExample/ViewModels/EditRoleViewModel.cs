using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestExample.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        
        public string Id { get; set; }
        [Display(Name = "Role-ի նոր անունը")]
        [Required(ErrorMessage = "Role-ի նոր անունը մուտքագրված չէ")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
