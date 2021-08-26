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
        public bool Success { get; set; }
        public string? Message { get; set; }
        public object Data { get; set; }
    }
}
