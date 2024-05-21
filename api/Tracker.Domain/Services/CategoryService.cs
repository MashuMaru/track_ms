using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tracker.Data;
using Tracker.Data.Entities;
using Tracker.Domain.DTOs;

namespace Tracker.Domain.Services;

public interface ICategoryService 
{
    Task<ServiceResponse<bool>> CreateAsync(CategoryDto dto);
    Task<ServiceResponse<bool>> UpdateAsync(CategoryDto dto);
}

public class CategoryService : ICategoryService
{
    private readonly TrackerContext _dbContext;
    private readonly IMapper _mapper;

    public CategoryService(TrackerContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;   
        _mapper = mapper;
    }

    public async Task<ServiceResponse<bool>> CreateAsync(CategoryDto dto)
    {
        try 
        {
            
            // var mappedCategory = _mapper.Map<Category>(dto);
            //
            // await _dbContext.Categories.AddAsync(mappedCategory);
            // await _dbContext.SaveChangesAsync();

            return new ServiceResponse<bool>
            {
                IsSuccessful = true,
                Message = "Successfully created category."
            };
        }
        catch (Exception e)
        {
            return new ServiceResponse<bool>
            {
                IsSuccessful = false,
                Message = e.Message
            };
        }
    }

    public async Task<ServiceResponse<bool>> UpdateAsync(CategoryDto dto)
    {
        try
        {
            var category = await _dbContext.Categories.FirstOrDefaultAsync(x => x.Id == dto.Id);
            category.Name = dto.Name;
            category.Active = dto.Active;

            await _dbContext.SaveChangesAsync();
            return new ServiceResponse<bool>
            {
                IsSuccessful = true,
                Message = "Successfully updated category."
            };
        }
        catch (Exception e)
        {
            return new ServiceResponse<bool>
            {
                IsSuccessful = false,
                Message = e.Message
            };
            
        }
    }
}
