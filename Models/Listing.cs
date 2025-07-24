using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace SA_Auction.Models
{
    public class Listing
    {
        //properties in aucsion listing 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        //path for the image
        public string ImagePath { get; set; }
        //to show in the home page
        public bool IsSold { get; set; } = false;

        [Required]
        public string? IdentityUserId { get; set; } //to identify the user belongs to a listing
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }

        // can have multiple bids
        public List<Bid>? Bids { get; set; }
        // can have multiple coments. having one to many relatioships
        public List<Comment>? Comments { get; set; }

    }
}
