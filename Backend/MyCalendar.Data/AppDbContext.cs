using Microsoft.EntityFrameworkCore;
using MyCalendar.Domain.Entities;

namespace MyCalendar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CalendarEvent> CalendarEvents { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<SharedArea> SharedAreas { get; set; }
        public DbSet<SharedAreaUser> SharedAreaUsers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
