using SHB.Domain;

namespace SHB.Application.Models.Reponse
{
    public class FacultyDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<FieldOfStudy>? FieldOfStudies { get; set; }
    }
}
