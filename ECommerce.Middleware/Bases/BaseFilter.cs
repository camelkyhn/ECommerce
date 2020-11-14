using System;
using ECommerce.Middleware.Enums;

namespace ECommerce.Middleware.Bases
{
    public abstract class BaseFilter
    {
        private int _pageSize;
        public int PageSize
        {
            get => _pageSize <= 0 ? 5 : _pageSize;
            set => _pageSize = value <= 0 ? 5 : value;
        }

        private int _pageNumber;
        public int PageNumber
        {
            get => _pageNumber <= 0 ? 1 : _pageNumber;
            set => _pageNumber = value <= 0 ? 1 : value;
        }

        public int TotalCount { get; set; }

        public bool IsAllData { get; set; } = false;

        public bool IsRecentItems { get; set; } = false;

        public DateTime? DateBefore { get; set; }

        public DateTime? DateAfter { get; set; }

        public string UpdatedUserName { get; set; }

        public Status? Status { get; set; }
    }
}