namespace MyCalendar.Domain.Entities
{
    public class SharedAreaUser
    {
        public int Id { get; set; }
        public SharedArea SharedArea { get; set; }
        public User User { get; set; }
    }
}
