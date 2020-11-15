using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;

namespace ECommerce.Middleware.Filter.Core
{
    public class ControllerFilter : BaseFilter
    {
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 1)]
        public string AreaName { get; set; }
    }
}