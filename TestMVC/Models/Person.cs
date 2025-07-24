using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public int Age { get; set; }
    }
}