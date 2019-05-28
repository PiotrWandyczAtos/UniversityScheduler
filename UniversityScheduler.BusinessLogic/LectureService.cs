using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UniversityScheduler.DataAccess;
using UniversityScheduler.DataAccess.Model;

namespace UniversityScheduler.BusinessLogic
{
    public class LectureService
    {
        public List<LectureView> GetLectures()
        {
            using (var db = new UniversitySchedulerContext(new DbContextOptions<UniversitySchedulerContext>()))
            {
                return db.LectureView
                    .OrderBy(x => x.DayOfWeek)
                    .ThenBy(x => x.StartTime)
                    .ToList();
            }
        }

        public List<LectureView> GetLecturesWhereUserIsntRegisteredYet(string userId)
        {
            using (var db = new UniversitySchedulerContext(new DbContextOptions<UniversitySchedulerContext>()))
            {
                var lectureIds = db.ScheduleView.Where(x => x.UserId == userId).Select(x => x.LectureId);

                return db.LectureView
                    .Where(x => !lectureIds.Contains(x.LectureId))
                    .OrderBy(x => x.DayOfWeek)
                    .ThenBy(x => x.StartTime)
                    .ToList();
            }
        }
    }
}