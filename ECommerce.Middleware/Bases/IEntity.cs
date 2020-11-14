using System;
using ECommerce.Middleware.Entities.Identity;
using ECommerce.Middleware.Enums;

namespace ECommerce.Middleware.Bases
{
    public interface IEntity : IIdentified
    {
        Guid UpdatedUserId { get; set; }

        DateTime UpdatedDate { get; set; }

        DateTime CreatedDate { get; set; }

        Status Status { get; set; }

        User UpdatedUser { get; set; }
    }
}