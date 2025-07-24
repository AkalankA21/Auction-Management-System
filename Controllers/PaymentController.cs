using Microsoft.AspNetCore.Mvc;
using SA_Auction.Data;
using SA_Auction.Models;

namespace SA_Auction.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Payment
        public IActionResult Checkout()
        {
            // Calculate the total amount from the cart (you can adjust this logic as per your cart implementation)
            var totalAmount = CalculateTotal(); // Implement this method
            ViewBag.TotalAmount = totalAmount;
            return View(new Checkout()); // Pass a new Checkout object to the view
        }

        // POST: Payment
        [HttpPost]
        public IActionResult CompletePayment(Checkout checkout)
        {
            if (ModelState.IsValid)
            {
                // Save the checkout data
                _context.Checkouts.Add(checkout);
                _context.SaveChanges();

                // Redirect to a success page or handle payment processing here
                return RedirectToAction("PaymentSuccess");
            }
            return View("Checkout", checkout);
        }

        private decimal CalculateTotal()
        {
            // Calculate the total amount based on the items in the cart
            // Placeholder logic; implement your cart retrieval logic here
            decimal subtotal = 1000; // Example subtotal
            decimal tax = 100; // Example tax
            return subtotal + tax;
        }

        public IActionResult PaymentSuccess()
        {
            return View();
        }
    }

}
