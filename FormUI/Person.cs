﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }

        public string FullInfo
        {
            get 
            {
                // Maddy harrop (maddy@email.com)
                return $"{ FirstName } { LastName } ({ EmailAddress })";
            }
        }
    }
}
