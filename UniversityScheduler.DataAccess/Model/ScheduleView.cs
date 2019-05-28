using System;

namespace UniversityScheduler.DataAccess.Model
{
    public class ScheduleView
    {
        public int SchedulePartId { get; set; }
        public int LectureId { get; set; }
        public string SubjectName { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string UserId { get; set; }
    }
}