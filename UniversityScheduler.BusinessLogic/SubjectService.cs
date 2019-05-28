using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UniversityScheduler.DataAccess;
using UniversityScheduler.DataAccess.Model;

namespace UniversityScheduler.BusinessLogic
{
    public class SubjectService
    {
        public List<Subject> GetSubjects()
        {
            using (var db = new UniversitySchedulerContext(new DbContextOptions<UniversitySchedulerContext>()))
            {
                return db.Subject.ToList();
            }
        }
    }
}