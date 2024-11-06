using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Data.Models
{
    public class Student : Person
    {
        [Key]
        public Guid Id { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
