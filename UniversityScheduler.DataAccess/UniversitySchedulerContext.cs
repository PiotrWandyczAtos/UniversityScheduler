using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniversityScheduler.DataAccess.Model;

namespace UniversityScheduler.DataAccess
{
    public class UniversitySchedulerContext : IdentityDbContext
    {
        public UniversitySchedulerContext(DbContextOptions<UniversitySchedulerContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Query<ScheduleView>().ToView("vw_GetScheduleForUser");
            modelBuilder.Query<LectureView>().ToView("vw_GetLectures");
        }

        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbQuery<ScheduleView> ScheduleView { get; set; }
        public virtual DbQuery<LectureView> LectureView { get; set; }
    }
}