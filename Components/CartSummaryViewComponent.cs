using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent(Basket temp)
        {
            basket = temp;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
