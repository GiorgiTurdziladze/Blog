using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Blog.DAL.Interfaces;

namespace Blog.DAL.Domains
{
    [Table("Posts")]
    public class Post: IDbEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public String Title { get; set; }

        public String PhotoPath { get; set; }

        public String Description { get; set; }


        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
