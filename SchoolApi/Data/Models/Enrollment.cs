using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Data.Models
{
    public class Enrollment
    {
        [Key]
        public Guid Id { get; set; }

        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }

        public Guid? CourseId { get; set; }
        public Course? Course { get; set; }

        public Guid? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;
    }
}
