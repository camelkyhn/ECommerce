using System;
using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;
using ECommerce.Middleware.Entities.Identity;

namespace ECommerce.Middleware.Entities.Core
{
    public class ControllerActionRole : Entity
    {
        [Required]
        public Guid ControllerActionId { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        public virtual ControllerAction ControllerAction { get; set; }
        public virtual Role Role { get; set; }
    }
}