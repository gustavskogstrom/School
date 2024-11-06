using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Data.Models
{
    public class Admin : Person
    {
        [Key]
        public Guid Id { get; set; }
    }
}
