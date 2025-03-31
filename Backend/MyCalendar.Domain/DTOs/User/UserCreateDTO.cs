using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalendar.Domain.DTOs.User
{
    public class UserCreateDTO
    {
        public String Name { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Photo { get; set; }
    }
}
