using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;

namespace ECommerce.Middleware.Entities.Core
{
    public class Controller : Entity
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        public Guid? AreaId { get; set; }

        public virtual Area Area { get; set; }

        public virtual ICollection<ControllerAction> ControllerActions { get; set; }
    }
}