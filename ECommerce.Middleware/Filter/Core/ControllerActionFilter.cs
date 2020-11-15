using System.ComponentModel.DataAnnotations;
using ECommerce.Middleware.Bases;

namespace ECommerce.Middleware.Filter.Core
{
    public class ControllerActionFilter : BaseFilter
    {
        [StringLength(100, MinimumLength = 1)]
        public string ControllerName { get; set; }

        [StringLength(100, MinimumLength = 1)]
        public string ActionName { get; set; }
    }
}