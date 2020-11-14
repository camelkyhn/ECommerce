using System.Text.Json.Serialization;

namespace ECommerce.Middleware.System
{
    public class Pagination
    {
        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("pageNumber")]
        public int PageNumber { get; set; }

        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }
    }
}