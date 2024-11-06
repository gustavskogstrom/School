using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Middleware
{
    public class CourseDto
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        //[Required]
        //public string Code { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
