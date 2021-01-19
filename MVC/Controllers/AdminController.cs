using FreakyFashion.Data.Models;
using FreakyFashion.Repo;

namespace FreakyFashion.MWC.Controllers
{
    public class AdminController:Controller
    {

        private readonly FreakyFashionContext _context;

        public AdminController(FreakyFashionContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewModel viewModel = new ViewModel();
            viewModel.Clothing = _context.Clothing;
            viewModel.Category = _context.Category;
            return View(viewModel);
        }
    }
}
