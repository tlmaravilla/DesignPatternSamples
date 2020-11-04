using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mediator.Data
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact{Id = 1, FirstName = "Bill", LastName = "Gates"},
                new Contact{Id = 2, FirstName = "Steve", LastName = "Jobs"},
                new Contact{Id = 3, FirstName = "Satya", LastName = "Nadella"});
        }
    }
}
