using System.Net;

namespace Infrastructure.API
{
    public readonly struct ApiResult<TData>
    {
        public bool Success { get; }
        public TData? Data { get; }
        public string Message { get; }
        public string? ErrorDetails { get; }
        public HttpStatusCode? StatusCode { get; }

        // EXITO
        public ApiResult(TData data, string message = "Operación exitosa")
        {
            Success = true;
            Data = data;
            Message = message;
            ErrorDetails = null;
            StatusCode = HttpStatusCode.OK;
        }

        // ERROR/FALLO
        public ApiResult(string message, string? errorDetails = null, HttpStatusCode? statusCode = null)
        {
            Success = false;
            Data = default;
            Message = message;
            ErrorDetails = errorDetails;
            StatusCode = statusCode;
        }

        public static ApiResult<TData> FromSuccess(TData data, string message = "Operación exitosa")
            => new(data, message);

        public static ApiResult<TData> FromError(string message, string? errorDetails = null, HttpStatusCode? statusCode = null)
            => new(message, errorDetails, statusCode);
    }
}
