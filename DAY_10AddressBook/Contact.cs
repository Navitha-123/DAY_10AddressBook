﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_10AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Phonenumber { get; set; }

        public string Emailid { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long ZipCode { get; set; }
    }
}
