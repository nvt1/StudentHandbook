using SHB.Domain;

namespace SHB.Application.Models.Request.User
{
    public class CreateUserRequest
    {
        //[Required]
        public string? StudentCode { get; set; }
        //[Required]
        public string? FirstName { get; set; }
        //[Required]
        public string? MiddleName { get; set; }
        //[Required]
        public string? LastName { get; set; }
        //[Required]
        public int? FacultyId { get; set; }
        //[Required]
        public DateTime? BirthDay { get; set; }
        //[Required]
        public int? ProgramId { get; set; }
        //[Required]
        public int? UserTypeId { get; set; }
        //[Required]
        public UserType? UserType { get; set; }
        //[Required]
        public string? Address { get; set; }
        //[Required]
        public string? City { get; set; }
        //[Required]
        public string? Country { get; set; }
        //[Required]
        public string? PostalCode { get; set; }
        //[Required]
        public string? Phone { get; set; }
        //[Required]
        public string? Email { get; set; }
        //[Required]
        public string? Password { get; set; }
        //[Required]
        public int? FieldOfStudyId { get; set; }
    }
}
