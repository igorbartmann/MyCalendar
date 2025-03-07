using MyCalendar.Domain.Enums;

namespace MyCalendar.Domain.Entities
{
    public class Email
    {
        public int Id { get; set; }
        public String From { get; set; }
        public String To { get; set; }
        public String Title { get; set; }
        public String Message { get; set; }
        public EnumEmailStatus Status { get; set; }
    }
}
