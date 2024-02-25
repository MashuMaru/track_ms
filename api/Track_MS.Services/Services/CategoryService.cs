using Track_MS.Services.Models.DTOs;

namespace Track_MS.Services.Services 
{
    public interface ICategoryService 
    {   
        Task<ServiceResponse<string>> GenerateIdentifierAsync();
    }

    public class CategoryService : ICategoryService
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
                Data = $"CATEGORY identifier: {uniqueIdentifier}."
            };
        }
    }
}
