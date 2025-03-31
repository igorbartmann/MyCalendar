using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalendar.Domain.Entities
{
    public class Response<T>
    {
        public T? Data { get; set; }
        public String? Message { get; set; }
        public bool Success { get; set; }
    }
}
