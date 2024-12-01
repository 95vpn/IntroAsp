using IntroAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroAsp.Controllers
{
    public class BrandController : Controller
    {
        private readonly CervezasContext _context;

        public BrandController(CervezasContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _context.Brands.ToListAsync());
        }
    }
}
