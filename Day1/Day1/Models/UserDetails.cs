﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day1.Models
{
    public class UserDetails
    {
        [StringLength(7, MinimumLength = 2, ErrorMessage = "Username length should be between 2 and 7")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}