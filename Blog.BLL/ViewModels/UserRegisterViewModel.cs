using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blog.BLL.ViewModels
{
    public class UserRegisterViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name Should be inserted")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "LastName should be written")]
        public String LastName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Email cannot exceed 50 characters")]
        [EmailAddress]
        public String Email { get; set; }

        [Required(ErrorMessage = "Password should be inserted")]
        [StringLength(255, ErrorMessage = "Must be between 6 and 255 characters", MinimumLength = 6)]
        public String Password { get; set; }

        [Required(ErrorMessage = "You should confirm password")]
        [Compare(nameof(Password), ErrorMessage = "Confirm Password is mismatched to Password")]
        public String ConfirmPassword { get; set; }
    }
}
