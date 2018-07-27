using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}