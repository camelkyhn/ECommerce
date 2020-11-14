using System;
using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Entities.Identity;
using ECommerce.Middleware.Enums;

namespace ECommerce.Middleware.Bases
{
    public abstract class Entity : Identified, IEntity
    {
        [Required]
        public Guid UpdatedUserId { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public Status Status { get; set; }

        public virtual User UpdatedUser { get; set; }
    }
}