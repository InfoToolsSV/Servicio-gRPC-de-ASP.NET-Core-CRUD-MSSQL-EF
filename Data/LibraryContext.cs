using LibraryGrpcService.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryGrpcService.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set;}
    }
}