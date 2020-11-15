using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;

namespace ECommerce.Middleware.Filter.Identity
{
    public class UserFilter : BaseFilter
    {
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 1)]
        public string Email { get; set; }
    }
}