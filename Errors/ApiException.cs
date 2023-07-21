namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statuscode, string message, string details)
        {
            Statuscode = statuscode;
            Message = message;
            Details = details;
        }

        public int Statuscode { get; set; }
        public string Message { get; set; } 

        public string Details { get; set; }

    }
}