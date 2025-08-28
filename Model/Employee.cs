using System.ComponentModel.DataAnnotations;

namespace WebApiEmployee.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public required string Role { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; } 

        [Required]
        public string Address { get; set; }
    }
}
