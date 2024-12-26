using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab5Client.DataAccess.Model
{
    public class Grade
    {
        public int GradeId { get; set; }
        public int Value { get; set; }
        [Required]
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        [Required]
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
        [Required]
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public DateTime? CreateAt { get; set; }
        public override string? ToString()
        {
            return $"Value:{Value}," +
                $" CreateAt:{CreateAt}";
        }
    }
}
