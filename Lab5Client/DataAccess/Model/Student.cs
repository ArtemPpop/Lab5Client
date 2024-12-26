using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;

namespace Lab5Client.DataAccess.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public int NumberClass { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public ICollection<Grade>? Grades { get; set; }
        public ICollection<Attendance>? Attendances { get; set; }
        public override string? ToString()
        {
            return $"DateOfBirth:{DateOfBirth}," +
                $" NumberClass:{NumberClass}" +
                $" Name:{Name}";
        }
    }
}
