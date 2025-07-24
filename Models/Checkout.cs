using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SA_Auction.Models
{
    public class Checkout
    {
        // Unique identifier for the checkout record
        public int Id { get; set; }

        // ID of the item that was won
        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Listing? Item { get; set; } // Foreign key relationship to Listing

        // ID of the user making the payment
        [Required]
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; } // Foreign key relationship to IdentityUser

        // Tax amount
        public decimal TaxAmount { get; set; }

        // Subtotal amount (amount user has to pay)
        public decimal SubtotalAmount { get; set; }

        // Date of checkout
        public DateTime CheckoutDate { get; set; } = DateTime.Now; // Default to current time
    }
}

