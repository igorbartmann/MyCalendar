namespace MyCalendar.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Photo { get; set; }
        public bool Blocked { get; set; }
        public Guid SecurityGuid { get; set; }
    }
}