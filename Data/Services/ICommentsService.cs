using SA_Auction.Models;

namespace SA_Auction.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
