using System.ComponentModel.DataAnnotations;

namespace a
{
    public class Student
    {
        [Key]   //ctrl+j
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";

    }
}
