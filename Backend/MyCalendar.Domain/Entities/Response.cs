namespace MyCalendar.Domain.Entities
{
    public class Response<T>
    {
        public T? Data { get; set; }
        public String? Message { get; set; }
        public bool Success { get; set; } = true;
    }
}
