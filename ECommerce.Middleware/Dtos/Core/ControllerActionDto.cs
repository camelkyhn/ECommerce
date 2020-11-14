using System;
using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;

namespace ECommerce.Middleware.Dtos.Core
{
    public class ControllerActionDto : BaseDto
    {
        [Required]
        public Guid ControllerId { get; set; }

        [Required]
        public Guid ActionId { get; set; }
    }
}