namespace MyCalendar.Domain.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public User User { get; set; }
        public String Message { get; set; }
    }
}
