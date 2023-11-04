using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace WebForm.Controllers
{
    public class LoginController : Controller
    {
        private readonly CourseDB _context;

        public LoginController(CourseDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Check the username and password for validity (e.g., in a database).
            // If the login is successful, you can set a user's session or authentication cookie.
            var student = _context.Students.FirstOrDefault(o => o.StudentName == username); 
            if (student !=null) // Replace with your validation logic
            {
                // Successful login
                return RedirectToAction("Index", "Home"); // Redirect to the dashboard or another page.
            }
            else
            {
                // Failed login
                ViewData["ErrorMessage"] = "Invalid username or password"; // Display an error message on the login page.
                return View("Index");
            }
        }
    }
}
