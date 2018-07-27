using System.ComponentModel.DataAnnotations;

namespace ConsoleApp
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}