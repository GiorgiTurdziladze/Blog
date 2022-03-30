using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blog.BLL.Models
{
    public class UserModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Email cannot exceed 50 characters")]
        [EmailAddress]
        public String Email { get; set; }

        [Required(ErrorMessage = "Password should be written")]
        public String Password { get; set; }
    }
}
