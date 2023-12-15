using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions options) : base(options)
        {

        }

        // will create the table for both items and auction bc they are related, but it wont give items a pluralized name (that's why we need to specify it in the Item class in the [Table] decorator)
        public DbSet<Auction> Auctions { get; set; }
    }
}