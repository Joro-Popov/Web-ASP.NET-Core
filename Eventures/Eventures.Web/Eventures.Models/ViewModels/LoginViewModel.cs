using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventures.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [RegularExpression("[\\w,-^,_,.,*,~]{3,}", ErrorMessage = "Username is invalid!")]
        public string Username { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Password must be at least {1} characters long!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
