using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;

namespace ECommerce.Middleware.Filter.Identity
{
    public class RoleFilter : BaseFilter
    {
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }
    }
}