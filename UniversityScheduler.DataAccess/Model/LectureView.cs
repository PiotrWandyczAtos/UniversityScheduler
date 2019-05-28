using System;

namespace UniversityScheduler.DataAccess.Model
{
    public class LectureView
    {
        public int LectureId { get; set; }
        public string SubjectName { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
