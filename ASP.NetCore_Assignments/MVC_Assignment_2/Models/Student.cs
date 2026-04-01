using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MVC_Assignment_2.Models
{
    /*public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        // Navigation
        public List<Course> Courses { get; set; }
    }*/

    public class Student
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Name is required")]
        //[StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        public string Name { get; set; }

        //[Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }

        //[EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
