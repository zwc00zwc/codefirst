﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public DateTime? RegistrationDate { get; set; }
        //public DateTime? LastLoginDate { get; set; }
    }
}