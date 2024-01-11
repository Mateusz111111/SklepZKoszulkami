using Microsoft.AspNetCore.Mvc;
using SklepZKoszulkami.Repository.IRepository;
using SklepZKoszulkami.ViewModels;
using System.Security.Claims;

namespace SklepZKoszulkami.Controllers
{
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public ShoppingCartVM ShoppingCartVM { get; set; }
        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            //var claimsIdentity = (ClaimsIdentity)User.Identity;
            //var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            //ShoppingCartVM = new()
            //{
            //    ShoppingCartList = _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId,
            //    includeProperties: "Product"),
            //    OrderHeader = new()
            //};

            //foreach (var cart in ShoppingCartVM.ShoppingCartList)
            //{
            //    cart.Price = GetPriceBasedOnQuantity(cart);
            //    ShoppingCartVM.OrderHeader.OrderTotal += (cart.Price * cart.Count);
            //}

            return View(ShoppingCartVM);
        }
    }
}
