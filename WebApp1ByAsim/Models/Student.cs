using System.ComponentModel.DataAnnotations;

namespace WebApp1ByAsim.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student ID is required")]
        [Range(1, 1000, ErrorMessage = "Student ID must be in the range 1 to 1000")]
        public int StdID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address cannot exceed 100 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Faculty is required")]
        [StringLength(50, ErrorMessage = "Faculty cannot exceed 50 characters")]
        public string Faculty { get; set; }
    }
}
