using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SA_Auction.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public double Price { get; set; }

        [Required]
        //if the user delet the bid will be deleted
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }

        //connecting bid to a list
        public int? ListingId { get; set; }
        [ForeignKey("ListingId")]
        public Listing? Listing { get; set; }
    }
}
