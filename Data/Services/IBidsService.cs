using SA_Auction.Models;

namespace SA_Auction.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
        Task<List<Bid>> GetWonBidsByUserIdAsync(string userId);
        IQueryable<Bid> GetAll();
    }
}
