using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;
using ECommerce.Middleware.Entities.Core;

namespace ECommerce.Middleware.Entities.Identity
{
    public class Role : Entity
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<ControllerActionRole> ControllerActionRoles { get; set; }
    }
}