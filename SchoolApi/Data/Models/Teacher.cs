using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Data.Models
{
    public class Teacher : Person
    {
        [Key]
        public Guid Id { get; set; }
        public string Subject { get; set; } = string.Empty;

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
