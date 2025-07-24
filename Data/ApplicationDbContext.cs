using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SA_Auction.Models;

namespace SA_Auction.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //making instance for three listings
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
    }
}
