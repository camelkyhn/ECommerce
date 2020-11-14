using System;

namespace ECommerce.Middleware.Bases
{
    public interface IIdentified
    {
        Guid Id { get; set; }
    }
}