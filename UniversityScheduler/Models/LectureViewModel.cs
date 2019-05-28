using System;

namespace UniversityScheduler.Models
{
    public class LectureViewModel
    {
        public string SubjectName { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}