using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestExample.MyModels
{
    public class CitizenUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SecondName { get; set; }

        public string Passport { get; set; }

    }
}
