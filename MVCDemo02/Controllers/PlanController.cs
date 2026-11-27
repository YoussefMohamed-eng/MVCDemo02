using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCDemo02.Contexts;

namespace MVCDemo02.Controllers
{
    public class PlanController : Controller
    {
        private GymDbContext dbContext = new GymDbContext();

        public IActionResult IndexTest()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var plans = await dbContext.Plans.ToListAsync();
            return View(plans);
        }
    }
}
