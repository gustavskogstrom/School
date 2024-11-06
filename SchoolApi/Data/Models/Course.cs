using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Data.Models
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        //[Required]
        //public string Code { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
