﻿using Microsoft.EntityFrameworkCore;
using SA_Auction.Models;

namespace SA_Auction.Data.Services
{
    public class BidsService: IBidsService
    {
        private readonly ApplicationDbContext _context;

        public BidsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Bid bid)
        {
            _context.Bids.Add(bid);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Bid> GetAll()
        {
            var applicationDbContext = from a in _context.Bids.Include(l => l.Listing).ThenInclude(l => l.User)
                                       select a;
            return applicationDbContext;
        }

        public async Task<List<Bid>> GetWonBidsByUserIdAsync(string userId)
        {
            return await _context.Bids
       .Include(b => b.Listing) // To fetch associated listing details
       .Where(b => b.IdentityUserId == userId && b.Listing.IsSold && b.Price == b.Listing.Price)
       .ToListAsync();
        }
    }


}
