using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab5Client.DataAccess.Model
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string? Name { get; set; }
        public ICollection<Grade>? Grades { get; set; }
        public override string? ToString()
        {
            return $" Name:{Name}";
        }
    }
}
