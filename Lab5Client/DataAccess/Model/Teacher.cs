using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab5Client.DataAccess.Model
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public ICollection<Grade>? Grades { get; set; }
        public ICollection<Subject>? Subjects { get; set; }
        public override string? ToString()
        {
            return $" Name:{Name}";
        }
    }
}
