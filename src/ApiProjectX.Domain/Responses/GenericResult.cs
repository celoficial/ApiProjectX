namespace ApiProjectX.Domain.Responses
{
    public class GenericResult
    {
        public GenericResult(string message = "", bool success = true, object data = null)
        {
            Success = success;
            Message = message;
            Data = data;
        }
        public bool Success { get; }
        public string? Message { get; }
        public object Data { get; }
    }
}
