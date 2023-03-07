﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Account
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(8,ErrorMessage ="Password must be a least six characters long!")]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password and its confirmation do not match")]
        public string ConfirmPassword { get; set; }
    }
}
