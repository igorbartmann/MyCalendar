namespace MyCalendar.Domain.Entities
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public SharedArea sharedArea { get; set; }
        public DateTimeOffset Date { get; set; }
        public String Description { get; set; }
    }
}
