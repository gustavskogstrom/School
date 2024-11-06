using SchoolApi.Data.Enums;

namespace SchoolApi.Data.Models
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.Student;

        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
