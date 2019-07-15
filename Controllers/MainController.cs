using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class MainController : Controller
    {
        // localhost:5000/
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Example = "This is the Viewbag functionality";
            // View looks the the file name that is name after your action
            // Views/Main/IndexOfMe.cshtml << file extension for razor files
            return View("Index");
        }
        // localhost:5000/projects
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }
        // localhost:5000/contact
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
        // localhost:5000/hello
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            // localhost:5000
            return RedirectToAction("Projects");
        }

        [HttpGet("users/{username}/{location}")]
        // localhost:5000/user/??
        public IActionResult HelloUser(string username, string location)
        {
            var response = new{user=username, place=location};
            if (location == "chicago")
                return View("Index");

            if(location == "Seattle")
                return Json(response);


            return RedirectToAction("Hello");
        }
    }
}