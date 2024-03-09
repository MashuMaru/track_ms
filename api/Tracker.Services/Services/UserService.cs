using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tracker.Data;
using Tracker.Data.Entities;
using Tracker.Services.DTOs;

namespace Tracker.Services.Services;

public interface IUserService 
{
    Task<ServiceResponse<string>> CreateUserAsync(UserDto userModel);
    Task<ServiceResponse<User>> GetUserByIdAsync(int id);
}

public class UserService : IUserService
{
    private readonly TrackerContext _dbContext;
    private readonly IMapper _mapper;

    public UserService(TrackerContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;   
        _mapper = mapper;
    }

    public async Task<ServiceResponse<string>> CreateUserAsync(UserDto userModel)
    {
        try 
        {
            var mappedUser = _mapper.Map<User>(userModel);

            await _dbContext.Users.AddAsync(mappedUser);
            await _dbContext.SaveChangesAsync();

            return new ServiceResponse<string>
            {
                IsSuccessful = true,
                Message = $"Successfully created account for {userModel.Username}. UserId: {mappedUser.Id}."
            };
        }
        catch (Exception e)
        {
            return new ServiceResponse<string>
            {
                IsSuccessful = false,
                Message = e.Message
            };

            throw new Exception("Something went wrong.", e);
        }
    }

    public async Task<ServiceResponse<User>> GetUserByIdAsync(int id)
    {
        try
        {
            return new ServiceResponse<User>
            {
                IsSuccessful = true,
                Data = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id)
            };
        }
        catch (Exception e)
        {
            return new ServiceResponse<User>
            {
                IsSuccessful = false,
                Message = e.Message
            };

            throw new Exception("Something went wrong.", e);
        }
    }
}
