using System;
using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Enums;

namespace ECommerce.Middleware.Bases
{
    public abstract class BaseDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Durum alanının seçilmesi zorunludur!")]
        public Status Status { get; set; }

        public Guid UpdatedUserId { get; set; }
    }
}