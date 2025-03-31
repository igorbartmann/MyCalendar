using MyCalendar.Application.Interfaces.Services;
using MyCalendar.Data;
using MyCalendar.Domain.DTOs.User;
using MyCalendar.Domain.Entities;

namespace MyCalendar.Application.Services
{
    public class UserService : IUserInterface
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Response<User>> CreateUser(UserCreateDTO userDTO)
        {
            Response<User> response = new Response<User>();
            try
            {
                var user = new User()
                {
                    Name = userDTO.Name,
                    BirthDate = userDTO.BirthDate,
                    Email = userDTO.Email,
                    Password = userDTO.Password,
                    Photo = userDTO.Photo,
                    Blocked = false,
                    SecurityGuid = new Guid()
                };

                _context.Add(user);
                await _context.SaveChangesAsync();

                response.Data = await _context.Users.FindAsync(user.Id);
                response.Message = "User created succesfully!";
            }
            catch (Exception ex) 
            { 
                response.Message = ex.Message;
                response.Success = false;
            }

            return response;
        }

        public async Task<Response<User>> UpdateUser(UserUpdateDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
