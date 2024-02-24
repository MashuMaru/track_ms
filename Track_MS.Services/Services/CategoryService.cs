namespace Track_MS.Services.Services
{
    public interface ICategoryService {
        Task<string> GenerateIdentifierAsync();
    }
    public class CategoryService : ICategoryService
    {
        public async Task<string> GenerateIdentifierAsync()
        {
            var uniqueIdentifier = new Guid();
            await Task.Run(() => {
                uniqueIdentifier = Guid.NewGuid();
            });

            return $"This is your unique CATEGORY identifier: {uniqueIdentifier}. Delivered from the new Category service.";
        }
    }
}