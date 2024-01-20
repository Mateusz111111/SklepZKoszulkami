using Microsoft.AspNetCore.Mvc;
using SklepZKoszulkami.Repository.IRepository;
using SklepZKoszulkami.ViewModels;
using System.Security.Claims;

namespace SklepZKoszulkami.Areas.Customer.Controllers
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
            return View(ShoppingCartVM);
        }

        
    }
}
