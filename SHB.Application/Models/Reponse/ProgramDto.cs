using SHB.Domain;

namespace SHB.Application.Models.Reponse
{
    public class ProgramDto
    {
        public string? Name { get; set; }
        public int? Year { get; set; }
        public int? FieldOfStudyId { get; set; }
        public FieldOfStudy? FieldOfStudy { get; set; }
        public List<Course>? Courses { get; set; }
    }
}
