using Track_MS.Services.Models.DTOs;

namespace Track_MS.Services.Services
{
    public interface IUserService {
        Task<ServiceResponse<string>> GenerateIdentifierAsync();
    }
    public class UserService : IUserService
    {
        public async Task<ServiceResponse<string>> GenerateIdentifierAsync()
        {
            var uniqueIdentifier = new Guid();
            await Task.Run(() => {
                uniqueIdentifier = Guid.NewGuid();
            });

            return new ServiceResponse<string>
            {
                IsSuccessful = true,
                Data = $"USER identifier: {uniqueIdentifier}."
            };
        }
    }
}