namespace Track_MS.Services.Models.DTOs;
public class ServiceResponse<T>
{
    public T Data { get; set; }
    public string Message { get; set; }
    public bool IsSuccessful { get; set; }
}
