using System.Text.Json.Serialization;

namespace SHB.Domain
{
    public class Course : BaseEntity
    {
        public string? CourseCode { get; set; }
        public string? Name { get; set; }
        public int? PracticalHours { get; set; }
        public int? TheoreticalHours { get; set; } // Đã sửa thành "TheoreticalHours"
        public int? Semester { get; set; } // Sửa loại dữ liệu từ int? thành int
        public int? ProgramId { get; set; }
        [JsonIgnore]
        public Program? Program { get; set; }
    }
}

