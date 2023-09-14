using Microsoft.AspNetCore.Mvc;
using WebApp.DAL;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly MyAppDbContext _context;

        public UserController(MyAppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        
        public JsonResult GetUsers()
        {
            var users = _context.Users.ToList();
            return Json(users);
        }
    }
}
