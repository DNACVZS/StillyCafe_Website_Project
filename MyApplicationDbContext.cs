using Microsoft.EntityFrameworkCore;
using _4003projectsetup.Data.Entities;

namespace _4003projectsetup.Data

{
    public class MyApplicationDbContext : DbContext
    {
        public MyApplicationDbContext(DbContextOptions<MyApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MailingList> MailingLists { get; set; }
    }
}