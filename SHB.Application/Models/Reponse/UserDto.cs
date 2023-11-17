using SHB.Domain;

namespace SHB.Application.Models.Reponse
{
    public class UserDto : BaseDto
    {
        public string? StudentCode { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public int? FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? ProgramId { get; set; }
        public Program? Program { get; set; }
        public int? UserTypeId { get; set; }
        public UserType? UserType { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; } // Đã sửa thành "Password"
        public int? FieldOfStudyId { get; set; } // Thuộc tính mới để thể hiện FieldOfStudy cho sinh viên
        public FieldOfStudy? FieldOfStudy { get; set; } // Đã thêm FieldOfStudy
    }
}
