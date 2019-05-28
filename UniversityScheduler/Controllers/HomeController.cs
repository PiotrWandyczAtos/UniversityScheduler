using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UniversityScheduler.BusinessLogic;
using UniversityScheduler.Models;

namespace UniversityScheduler.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetSubjects()
        {
            var service = new SubjectService();
            var data = service.GetSubjects().Select(x => new SubjectViewModel
            {
                Name = x.Name
            }).ToList();
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}