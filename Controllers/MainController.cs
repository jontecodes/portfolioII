using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class MainController : Controller
    {
        // localhost:5000/
        [HttpGet("")]
        public string Index()
        {
            return "This is my Index!";
        }
        // localhost:5000/projects
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }
        // localhost:5000/contact
        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}