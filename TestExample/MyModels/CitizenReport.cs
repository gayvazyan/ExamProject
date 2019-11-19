﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestExample.Models
{
    public class CitizenReport
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SecondName { get; set; }

        public string Passport { get; set; }

        public string PhoneNumber { get; set; }

        public double Result { get; set; }

        public int NumberTicket { get; set; }

        public string Email { get; set; }

        public DateTime TestDataTime { get; set; }

    }
}
