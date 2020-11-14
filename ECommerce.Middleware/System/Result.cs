using System;
using System.Text.Json.Serialization;

namespace ECommerce.Middleware.System
{
    public class Result
    {
        [JsonPropertyName("isSuccess")]
        public bool IsSucceeded { get; set; }

        [JsonPropertyName("logId")]
        public string LogId { get; set; }

        [JsonPropertyName("exceptionType")]
        public string ExceptionType { get; set; }

        [JsonPropertyName("exceptionMessage")]
        public string ExceptionMessage { get; set; }

        public void Error(Exception exception)
        {
            IsSucceeded      = false;
            ExceptionMessage = exception.Message;
            ExceptionType    = exception.GetType().FullName;
        }

        public static void Map(Result resultSource, Result resultTarget)
        {
            resultTarget.ExceptionMessage = resultSource.ExceptionMessage;
            resultTarget.ExceptionType    = resultSource.ExceptionType;
            resultTarget.IsSucceeded      = resultSource.IsSucceeded;
            resultTarget.LogId            = resultSource.LogId;
        }
    }

    public class Result<T> : Result
    {
        [JsonPropertyName("data")]
        public T Data { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        public void PaginationInfo(int pageSize, int pageNumber, int totalCount)
        {
            Pagination = new Pagination
            {
                PageSize   = pageSize,
                PageNumber = pageNumber,
                TotalCount = totalCount
            };
        }

        public void Success(T data)
        {
            IsSucceeded = true;
            Data        = data;
        }

        public void Success(T data, int pageSize, int pageNumber, int totalCount)
        {
            IsSucceeded = true;
            Data        = data;
            PaginationInfo(pageSize, pageNumber, totalCount);
        }

        public void Success(T data, Pagination paginationInfo)
        {
            IsSucceeded = true;
            Pagination  = paginationInfo;
            Data        = data;
        }

        public static void Map<TSource>(Result<TSource> resultSource, Result<T> resultTarget)
        {
            resultTarget.ExceptionMessage = resultSource.ExceptionMessage;
            resultTarget.ExceptionType    = resultSource.ExceptionType;
            resultTarget.IsSucceeded      = resultSource.IsSucceeded;
            resultTarget.LogId            = resultSource.LogId;
        }
    }
}