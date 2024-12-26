using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab5Client.DataAccess.Model
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        [Required]
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public DateTime? Date { get; set; }
        public bool IsPresent { get; set; }
        public override string? ToString()
        {
            return $"Date:{Date}," +
                $" IsPresent:{IsPresent}";
        }
    }
}
