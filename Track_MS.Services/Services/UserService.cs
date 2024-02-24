namespace Track_MS.Services.Services
{
    public interface IUserService {
        Task<string> GenerateIdentifierAsync();
    }
    public class UserService : IUserService
    {
        public async Task<string> GenerateIdentifierAsync()
        {
            var uniqueIdentifier = new Guid();
            await Task.Run(() => {
                uniqueIdentifier = Guid.NewGuid();
            });

            return $"This is your unique USER identifier: {uniqueIdentifier}. Delivered from the new User service.";
        }
    }
}