using SHB.Domain;

namespace SHB.Application.Models.Reponse
{
    public class CourseDto
    {
        public string? CourseCode { get; set; }
        public string? Name { get; set; }
        public int? PracticalHours { get; set; }
        public int? TheoreticalHours { get; set; } // Đã sửa thành "TheoreticalHours"
        public int Semester { get; set; } // Sửa loại dữ liệu từ int? thành int
        public int? ProgramId { get; set; }
        public Program? Program { get; set; }
    }
}
