﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Client.Models
{
    public class Login
    {
        [Required]
        [MaxLength(15)]
        [MinLength(5)]
        public string Username { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(25)]
        public string Password { get; set; }
    }
}
