namespace SHB.Application.Models.Request.Course
{
    public class CreateCourseRequest
    {
        public string? CourseCode { get; set; }
        public string? Name { get; set; }
        public int? PracticalHours { get; set; }
        public int? TheoreticalHours { get; set; }
        public int Semester { get; set; }
        public int? ProgramId { get; set; }
    }
}
