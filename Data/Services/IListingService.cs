using SA_Auction.Models;

namespace SA_Auction.Data.Services
{
    public interface IListingService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);
        Task<Listing> GetById(int? id);
        Task SaveChanges();
    }
}
