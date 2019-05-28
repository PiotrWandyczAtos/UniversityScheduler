using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniversityScheduler.BusinessLogic;
using UniversityScheduler.DataAccess.Model;
using UniversityScheduler.Models;

namespace UniversityScheduler.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        public IActionResult Schedule()
        {
            var userId = GetUserId();
            var service = new ScheduleService();
            var data = service.GetSchedule(userId);
            var mapped = Map(data);
            return View(mapped);
        }

        public IActionResult AddLecture()
        {
            var userId = GetUserId();
            var service = new LectureService();
            var data = service.GetLecturesWhereUserIsntRegisteredYet(userId);
            // TODO
            return View();
        }

        [HttpPost]
        public IActionResult AddLecture(int lectureId)
        {
            var userId = GetUserId();
            var service = new ScheduleService();
            service.AddLecture(userId, lectureId);
            return RedirectToAction(nameof(Schedule));
        }

        public IActionResult RemoveLecture()
        {
            var userId = GetUserId();
            var service = new ScheduleService();
            var data = service.GetSchedule(userId);
            // TODO
            return View();
        }

        [HttpPost]
        public IActionResult RemoveLecture(List<int> lectureIds)
        {
            var userId = GetUserId();
            var service = new ScheduleService();
            service.RemoveLectures(userId, lectureIds);
            return RedirectToAction(nameof(Schedule));
        }

        private string GetUserId()
        {
            return this.User.Claims.First(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;
        }

        private List<LectureViewModel> Map(List<ScheduleView> data)
        {
            return data.Select(x => new LectureViewModel
            {
                DayOfWeek = x.DayOfWeek,
                StartTime = x.StartTime,
                EndTime = x.EndTime,
                SubjectName = x.SubjectName
            }).ToList();
        }
    }
}