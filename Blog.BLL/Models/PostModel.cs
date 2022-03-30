using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Blog.BLL.Models
{
    public class PostModel
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Title should be written")]
        public String Title { get; set; }

        [Display(Name = "Add a picture")]
        [DataType(DataType.Upload)]
        [Required(ErrorMessage = "where is photo?")]
        public IFormFile PhotoPath { get; set; }
        public String FileName { get; set; }

        [Required(ErrorMessage = "Description should be written")]
        public String Description { get; set; }
        public DateTime DateCreated { get; set; }
        public String AuthorFullName { get; set; }

    }
}
