namespace Neckington.API.Middlewares
{
    public sealed class ErrorResponse
    {
        public required int StatusCode { get; init; }
        public required string Message { get; init; }
        public string? Details { get; init; }
    }
}
