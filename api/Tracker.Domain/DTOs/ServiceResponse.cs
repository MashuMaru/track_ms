namespace Tracker.Domain.DTOs
{
    public class ServiceResponse<T>
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}