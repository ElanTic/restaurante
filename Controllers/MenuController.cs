using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restaurante.Data;
using restaurante.Models;
using System.Diagnostics;
namespace restaurante.Controllers
{
    public class MenuController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public MenuController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Producto != null ?
                        View(await _context.Producto.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Categoria'  is null.");
        }

    }
}
