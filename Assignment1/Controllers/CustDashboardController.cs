using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class CustDashboardController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustDashboardController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            IEnumerable<CustDashboard>? objDashboardList = _db.CustDashboards;
            return View(objDashboardList);

        }
        public IActionResult CreateWidget()
        {
            IEnumerable<CustDashboard>? objDashboardList = _db.CustDashboards;
            return View(objDashboardList);
        }



    }
}
