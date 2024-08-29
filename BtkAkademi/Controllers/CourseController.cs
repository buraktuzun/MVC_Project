using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Candidates;
            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            if(Repository.Candidates.Any(x=> x.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("Email", "This email is already in use");
            }
            if(ModelState.IsValid)
            {
                Repository.AddCandidate(model);
                return View("FeedBack", model);
            }

            return View();
        }
    }
}