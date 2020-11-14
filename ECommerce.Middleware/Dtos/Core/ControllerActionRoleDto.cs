using System;
using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;

namespace ECommerce.Middleware.Dtos.Core
{
    public class ControllerActionRoleDto : BaseDto
    {
        [Required]
        public Guid ControllerActionId { get; set; }

        [Required]
        public Guid RoleId { get; set; }
    }
}