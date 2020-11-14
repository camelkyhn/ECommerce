using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;

namespace ECommerce.Middleware.Entities.Core
{
    public class ControllerAction : Entity
    {
        [Required]
        public Guid ActionId { get; set; }

        [Required]
        public Guid ControllerId { get; set; }

        public virtual Action Action { get; set; }
        public virtual Controller Controller { get; set; }
        public virtual ICollection<ControllerActionRole> ControllerActionRoles { get; set; }
    }
}