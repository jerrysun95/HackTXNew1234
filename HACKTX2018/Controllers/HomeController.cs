using System;
using System.Threading.Tasks;
using HACKTX2018.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HACKTX2018.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View();

        }

        // CAN BE USED TO GENERATE DYNACI HOME PAGE, DUNNO HOW
        //private readonly AppDbContext _context;

        //public HomeController(AppDbContext context)
        //{
        //    _context = context;
        //}

        //// GET: Organizations
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Organizations.ToListAsync());
        //}

        //// GET: Organizations/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var organization = await _context.Organizations
        //        .FirstOrDefaultAsync(m => m.OrganizationID == id);
        //    if (organization == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(organization);
        //}





    }
}