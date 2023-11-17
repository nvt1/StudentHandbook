namespace SHB.Application.Models.Request.Program
{
    public class CreateProgramRequest
    {
        public string? Name { get; set; }
        public int? Year { get; set; }
        public int? FieldOfStudyId { get; set; }
    }
}
