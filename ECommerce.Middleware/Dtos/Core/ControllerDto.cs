using System;
using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;

namespace ECommerce.Middleware.Dtos.Core
{
    public class ControllerDto : BaseDto
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        public Guid? AreaId { get; set; }
    }
}