using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;
using ECommerce.Middleware.Entities.Core;

namespace ECommerce.Middleware.Entities.Identity
{
    public class User : Entity
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<User> UpdatedUsers { get; set; }
        public virtual ICollection<Role> UpdatedRoles { get; set; }
        public virtual ICollection<UserRole> UpdatedUserRoles { get; set; }

        public virtual ICollection<Core.Action> UpdatedActions { get; set; }
        public virtual ICollection<Area> UpdatedAreas { get; set; }
        public virtual ICollection<Controller> UpdatedControllers { get; set; }
        public virtual ICollection<ControllerAction> UpdatedControllerActions { get; set; }
        public virtual ICollection<ControllerActionRole> UpdatedControllerActionRoles { get; set; }
    }
}