﻿using System.ComponentModel.DataAnnotations;

namespace CHUSHKA.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
