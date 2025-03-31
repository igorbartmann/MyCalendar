using MyCalendar.Domain.DTOs.User;
using MyCalendar.Domain.Entities;

namespace MyCalendar.Application.Interfaces.Services
{
    public interface IUserInterface
    {
        Task<Response<User>> CreateUser(UserCreateDTO userDTO);
        Task<Response<User>> UpdateUser(UserUpdateDTO userDTO);
    }
}
