using System.ComponentModel.DataAnnotations;

namespace Lab_8_9.Models
{
    public class EmployeeModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public string Designation { get; set; }
    }
}
