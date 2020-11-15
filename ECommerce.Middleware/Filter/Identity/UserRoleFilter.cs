using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;

namespace ECommerce.Middleware.Filter.Identity
{
    public class UserRoleFilter : BaseFilter
    {
        [StringLength(100, MinimumLength = 1)]
        public string UserName { get; set; }

        [StringLength(100, MinimumLength = 1)]
        public string RoleName { get; set; }
    }
}