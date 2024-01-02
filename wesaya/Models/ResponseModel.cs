namespace wesaya.Models
{
    public class ResponseModel
    {

        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public Object? Data { get; set; } = null;

    }
}
