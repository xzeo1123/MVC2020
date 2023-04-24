﻿using System.ComponentModel.DataAnnotations;

namespace CSharp_MVC.Models
{
    public class Signin
    {
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Password { get; set; }
    }
}
