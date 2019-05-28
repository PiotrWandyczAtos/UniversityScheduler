using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UniversityScheduler.DataAccess;
using UniversityScheduler.DataAccess.Model;

namespace UniversityScheduler.BusinessLogic
{
    public class ScheduleService
    {
        public List<ScheduleView> GetSchedule(string userId)
        {
            using (var db = new UniversitySchedulerContext(new DbContextOptions<UniversitySchedulerContext>()))
            {
                return db.ScheduleView
                    .Where(x => x.UserId == userId)
                    .OrderBy(x => x.DayOfWeek)
                    .ThenBy(x => x.StartTime)
                    .ToList();
            }
        }

        public void AddLecture(string userId, int lectureId)
        {
            // do tabelki Schedule
        }

        public void RemoveLectures(string userId, List<int> lectureIds)
        {
            // z tabelki Schedule
        }
    }
}