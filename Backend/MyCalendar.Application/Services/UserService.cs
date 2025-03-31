using MyCalendar.Application.Interfaces.Services;
using MyCalendar.Domain.DTOs.User;
using MyCalendar.Domain.Entities;

namespace MyCalendar.Application.Services
{
    public class UserService : IUserService
    {
        public Task<Response<User>> CreateUser(UserCreateDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public Task<Response<User>> UpdateUser(UserUpdateDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
