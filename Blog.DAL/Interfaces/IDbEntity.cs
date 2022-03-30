using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DAL.Interfaces
{
    public interface IDbEntity
    {
        Guid Id { get; set; }

        DateTime DateCreated { get; set; }

        DateTime? DateChanged { get; set; }

        DateTime? DateDeleted { get; set; }
    }
}
