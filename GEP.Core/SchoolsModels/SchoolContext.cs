using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GEP.Core.SchoolsModels.Mapping;

namespace GEP.Core.SchoolsModels
{
    public partial class SchoolContext : BaseDbContext
    {
        static SchoolContext()
        {
            Database.SetInitializer<SchoolContext>(null);
        }

        public SchoolContext()
            : base("Name=SchoolContext")
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<OnlineCourse> OnlineCourses { get; set; }
        public DbSet<OnsiteCourse> OnsiteCourses { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BlogMap());
            modelBuilder.Configurations.Add(new CourseMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new OfficeAssignmentMap());
            modelBuilder.Configurations.Add(new OnlineCourseMap());
            modelBuilder.Configurations.Add(new OnsiteCourseMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new StudentGradeMap());
        }
    }
}
