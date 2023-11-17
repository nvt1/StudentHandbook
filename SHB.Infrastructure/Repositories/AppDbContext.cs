using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SHB.Domain;

namespace SHB.Infrastructure.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<FieldOfStudy> FieldOfStudy { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Program>(program =>
            {
                program.HasOne(p => p.FieldOfStudy)
                    .WithMany(f => f.Programs)
                    .HasForeignKey(p => p.FieldOfStudyId);
            });

            modelBuilder.Entity<User>(user =>
            {
                user.HasOne(u => u.Program)
                    .WithMany()
                    .HasForeignKey(u => u.ProgramId);

                user.HasOne(u => u.FieldOfStudy)
                    .WithMany()
                    .HasForeignKey(u => u.FieldOfStudyId);
            });

            modelBuilder.Entity<FieldOfStudy>(fieldOfStudy =>
            {
                fieldOfStudy.HasOne(fos => fos.Faculty)
                    .WithMany(f => f.FieldOfStudies)
                    .HasForeignKey(fos => fos.FacultyId);
            });

            modelBuilder.Entity<Course>(course =>
            {
                course.HasOne(c => c.Program)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(c => c.ProgramId);
            });

            modelBuilder.Entity<Faculty>(faculty =>
            {
                faculty.HasMany(f => f.FieldOfStudies)
                    .WithOne(fos => fos.Faculty)
                    .HasForeignKey(fos => fos.FacultyId);
            });


            SeedData(modelBuilder);
        }


        private void SeedData(ModelBuilder modelBuilder)
        {
            SeedDataUserType(modelBuilder);
            SeedDataFaculty(modelBuilder);
            SeedDataFieldOfStudy(modelBuilder);
            SeedDataProgram(modelBuilder);
            SeedDataCourse(modelBuilder);
            SeedDataUser(modelBuilder);
        }

        private void SeedDataUserType(ModelBuilder modelBuilder)
        {
            var userTypes = new List<UserType>
    {
        new UserType { Id = 1, UserTypeCode = "Admin", UserTypeDesc = "Administrator", CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new UserType { Id = 2, UserTypeCode = "Teacher", UserTypeDesc = "Teacher", CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new UserType { Id = 3, UserTypeCode = "Student", UserTypeDesc = "Student", CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 }
    };

            modelBuilder.Entity<UserType>().HasData(userTypes);
        }
        private void SeedDataFaculty(ModelBuilder modelBuilder)
        {
            var faculties = new List<Faculty>
    {
        new Faculty { Id = 1, Name = "Faculty of Computer Science", Description = "Description for Computer Science faculty", CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new Faculty { Id = 2, Name = "Faculty of Electrical Engineering", Description = "Description for Electrical Engineering faculty", CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new Faculty { Id = 3, Name = "Faculty of Mechanical Engineering", Description = "Description for Mechanical Engineering faculty", CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 }
    };

            modelBuilder.Entity<Faculty>().HasData(faculties);
        }
        private void SeedDataFieldOfStudy(ModelBuilder modelBuilder)
        {
            var fieldsOfStudy = new List<FieldOfStudy>
    {
        new FieldOfStudy { Id = 1, Name = "Computer Science", FacultyId = 1, CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new FieldOfStudy { Id = 2, Name = "Electrical Engineering", FacultyId = 2, CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new FieldOfStudy { Id = 3, Name = "Mechanical Engineering", FacultyId = 3, CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new FieldOfStudy { Id = 4, Name = "Physics", FacultyId = 1, CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new FieldOfStudy { Id = 5, Name = "Mathematics", FacultyId = 2, CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 }
    };

            modelBuilder.Entity<FieldOfStudy>().HasData(fieldsOfStudy);
        }
        private void SeedDataProgram(ModelBuilder modelBuilder)
        {
            var programs = new List<Program>
    {
        new Program { Id = 1, Name = "Computer Science Program", Year = 4, FieldOfStudyId = 1, CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new Program { Id = 2, Name = "Electrical Engineering Program", Year = 4, FieldOfStudyId = 2, CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new Program { Id = 3, Name = "Mechanical Engineering Program", Year = 4, FieldOfStudyId = 3, CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new Program { Id = 4, Name = "Physics Program", Year = 3, FieldOfStudyId = 4, CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 },
        new Program { Id = 5, Name = "Mathematics Program", Year = 3, FieldOfStudyId = 5, CreatedAt = DateTime.Now, CreatedBy = "Admin", UpdatedAt = DateTime.Now, UpdatedBy = "Admin", Status = 1 }
    };

            modelBuilder.Entity<Program>().HasData(programs);
        }
        private void SeedDataCourse(ModelBuilder modelBuilder)
        {
            var courses = new[]
            {
        new Course
        {
            Id = 1,
            CourseCode = "C001",
            Name = "Introduction to Programming",
            PracticalHours = 30,
            TheoreticalHours = 60,
            Semester = 1,
            ProgramId = 1
        },
        new Course
        {
            Id = 2,
            CourseCode = "C002",
            Name = "Data Structures and Algorithms",
            PracticalHours = 35,
            TheoreticalHours = 55,
            Semester = 1,
            ProgramId = 1
        },
        new Course
        {
            Id = 3,
            CourseCode = "C003",
            Name = "Database Management",
            PracticalHours = 25,
            TheoreticalHours = 45,
            Semester = 1,
            ProgramId = 2
        },
        new Course
        {
            Id = 4,
            CourseCode = "C004",
            Name = "Web Development",
            PracticalHours = 40,
            TheoreticalHours = 50,
            Semester = 1,
            ProgramId = 2
        },
        new Course
        {
            Id = 5,
            CourseCode = "C005",
            Name = "Operating Systems",
            PracticalHours = 30,
            TheoreticalHours = 60,
            Semester = 1,
            ProgramId = 3
        },
        new Course
        {
            Id = 6,
            CourseCode = "C006",
            Name = "Computer Networks",
            PracticalHours = 35,
            TheoreticalHours = 55,
            Semester = 1,
            ProgramId = 3
        },
        new Course
        {
            Id = 7,
            CourseCode = "C007",
            Name = "Software Engineering",
            PracticalHours = 30,
            TheoreticalHours = 60,
            Semester = 1,
            ProgramId = 4
        },
        new Course
        {
            Id = 8,
            CourseCode = "C008",
            Name = "Machine Learning",
            PracticalHours = 40,
            TheoreticalHours = 50,
            Semester = 1,
            ProgramId = 4
        },
        new Course
        {
            Id = 9,
            CourseCode = "C009",
            Name = "Mobile App Development",
            PracticalHours = 35,
            TheoreticalHours = 55,
            Semester = 1,
            ProgramId = 5
        },
        new Course
        {
            Id = 10,
            CourseCode = "C010",
            Name = "Artificial Intelligence",
            PracticalHours = 40,
            TheoreticalHours = 50,
            Semester = 1,
            ProgramId = 5
        }
    };

            modelBuilder.Entity<Course>().HasData(courses);
        }
        private void SeedDataUser(ModelBuilder modelBuilder)
        {
            var users = new List<User>
    {
        new User
        {
            Id = 1,
            FirstName = "John",
            MiddleName = "Doe",
            LastName = "Smith",
            FullName = "John Doe Smith",
            BirthDay = new DateTime(1990, 5, 15),
            ProgramId = 1,
            UserTypeId = 1,
            Address = "123 Main Street",
            City = "Anytown",
            Country = "USA",
            PostalCode = "12345",
            Phone = "123-456-7890",
            Email = "john.doe@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 1,
            FieldOfStudyId = 1
        },
        new User
        {
            Id = 2,
            FirstName = "Alice",
            MiddleName = "Eve",
            LastName = "Johnson",
            FullName = "Alice Eve Johnson",
            BirthDay = new DateTime(1985, 8, 22),
            ProgramId = 2,
            UserTypeId = 2,
            Address = "456 Elm Street",
            City = "Othercity",
            Country = "Canada",
            PostalCode = "54321",
            Phone = "456-789-0123",
            Email = "alice.eve@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 2,
            FieldOfStudyId = 2
        },
        new User
        {
            Id = 3,
            FirstName = "Michael",
            MiddleName = "James",
            LastName = "Brown",
            FullName = "Michael James Brown",
            BirthDay = new DateTime(1988, 12, 10),
            ProgramId = 3,
            UserTypeId = 3,
            Address = "789 Oak Street",
            City = "Anothercity",
            Country = "UK",
            PostalCode = "98765",
            Phone = "789-012-3456",
            Email = "michael.james@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 3,
            FieldOfStudyId = 3
        },
        new User
        {
            Id = 4,
            FirstName = "Sarah",
            MiddleName = "Jane",
            LastName = "Wilson",
            FullName = "Sarah Jane Wilson",
            BirthDay = new DateTime(1991, 3, 18),
            ProgramId = 4,
            UserTypeId = 1,
            Address = "101 Oak Lane",
            City = "Sometown",
            Country = "USA",
            PostalCode = "54321",
            Phone = "555-123-4567",
            Email = "sarah.jane@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 3,
            FieldOfStudyId = 4
        },
        new User
        {
            Id = 5,
            FirstName = "Robert",
            MiddleName = "David",
            LastName = "Jones",
            FullName = "Robert David Jones",
            BirthDay = new DateTime(1987, 9, 8),
            ProgramId = 5,
            UserTypeId = 2,
            Address = "567 Elm Road",
            City = "Anytown",
            Country = "USA",
            PostalCode = "12345",
            Phone = "567-234-5678",
            Email = "robert.david@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 2,
            FieldOfStudyId = 5
        },
        new User
        {
            Id = 6,
            FirstName = "Emily",
            MiddleName = "Grace",
            LastName = "Martinez",
            FullName = "Emily Grace Martinez",
            BirthDay = new DateTime(1992, 6, 30),
            ProgramId = 1,
            UserTypeId = 3,
            Address = "222 Maple Street",
            City = "Othercity",
            Country = "Canada",
            PostalCode = "98765",
            Phone = "222-345-6789",
            Email = "emily.grace@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 1,
            FieldOfStudyId = 1
        },
        new User
        {
            Id = 7,
            FirstName = "William",
            MiddleName = "Joseph",
            LastName = "Lee",
            FullName = "William Joseph Lee",
            BirthDay = new DateTime(1986, 1, 12),
            ProgramId = 2,
            UserTypeId = 1,
            Address = "444 Cedar Lane",
            City = "Sometown",
            Country = "USA",
            PostalCode = "12345",
            Phone = "444-456-7890",
            Email = "william.joseph@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 2,
            FieldOfStudyId = 2
        },
        new User
        {
            Id = 8,
            FirstName = "Olivia",
            MiddleName = "Sophia",
            LastName = "Garcia",
            FullName = "Olivia Sophia Garcia",
            BirthDay = new DateTime(1993, 4, 2),
            ProgramId = 3,
            UserTypeId = 2,
            Address = "777 Pine Road",
            City = "Othercity",
            Country = "Canada",
            PostalCode = "54321",
            Phone = "777-567-1234",
            Email = "olivia.sophia@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 3,
            FieldOfStudyId = 3
        },
        new User
        {
            Id = 9,
            FirstName = "James",
            MiddleName = "Andrew",
            LastName = "Davis",
            FullName = "James Andrew Davis",
            BirthDay = new DateTime(1989, 7, 25),
            ProgramId = 4,
            UserTypeId = 3,
            Address = "555 Birch Lane",
            City = "Sometown",
            Country = "USA",
            PostalCode = "98765",
            Phone = "555-123-6789",
            Email = "james.andrew@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 1,
            FieldOfStudyId = 4
        },
        new User
        {
            Id = 10,
            FirstName = "Sophia",
            MiddleName = "Grace",
            LastName = "Hernandez",
            FullName = "Sophia Grace Hernandez",
            BirthDay = new DateTime(1994, 10, 14),
            ProgramId = 5,
            UserTypeId = 1,
            Address = "333 Cedar Road",
            City = "Sometown",
            Country = "USA",
            PostalCode = "12345",
            Phone = "333-234-5678",
            Email = "sophia.grace@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 2,
            FieldOfStudyId = 5
        },
        new User
        {
            Id = 11,
            FirstName = "Logan",
            MiddleName = "David",
            LastName = "Lopez",
            FullName = "Logan David Lopez",
            BirthDay = new DateTime(1995, 8, 6),
            ProgramId = 1,
            UserTypeId = 2,
            Address = "777 Pine Lane",
            City = "Othercity",
            Country = "Canada",
            PostalCode = "54321",
            Phone = "777-567-6789",
            Email = "logan.david@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 1,
            FieldOfStudyId = 1
        },
        new User
        {
            Id = 12,
            FirstName = "Ava",
            MiddleName = "Emily",
            LastName = "Thompson",
            FullName = "Ava Emily Thompson",
            BirthDay = new DateTime(1996, 12, 3),
            ProgramId = 2,
            UserTypeId = 3,
            Address = "444 Maple Lane",
            City = "Anothercity",
            Country = "UK",
            PostalCode = "98765",
            Phone = "444-234-5678",
            Email = "ava.emily@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 2,
            FieldOfStudyId = 2
        },
        new User
        {
            Id = 13,
            FirstName = "Noah",
            MiddleName = "William",
            LastName = "Wilson",
            FullName = "Noah William Wilson",
            BirthDay = new DateTime(1990, 2, 17),
            ProgramId = 3,
            UserTypeId = 1,
            Address = "123 Main Road",
            City = "Anytown",
            Country = "USA",
            PostalCode = "12345",
            Phone = "123-345-6789",
            Email = "noah.william@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 3,
            FieldOfStudyId = 3
        },
        new User
        {
            Id = 14,
            FirstName = "Mia",
            MiddleName = "Olivia",
            LastName = "Garcia",
            FullName = "Mia Olivia Garcia",
            BirthDay = new DateTime(1991, 6, 21),
            ProgramId = 4,
            UserTypeId = 2,
            Address = "456 Elm Lane",
            City = "Othercity",
            Country = "Canada",
            PostalCode = "54321",
            Phone = "456-567-8901",
            Email = "mia.olivia@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 3,
            FieldOfStudyId = 4
        },
        new User
        {
            Id = 15,
            FirstName = "Liam",
            MiddleName = "Joseph",
            LastName = "Martinez",
            FullName = "Liam Joseph Martinez",
            BirthDay = new DateTime(1989, 10, 19),
            ProgramId = 5,
            UserTypeId = 3,
            Address = "555 Oak Road",
            City = "Sometown",
            Country = "USA",
            PostalCode = "98765",
            Phone = "555-234-8901",
            Email = "liam.joseph@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 2,
            FieldOfStudyId = 5
        },
        new User
        {
            Id = 16,
            FirstName = "Isabella",
            MiddleName = "Sophia",
            LastName = "Lee",
            FullName = "Isabella Sophia Lee",
            BirthDay = new DateTime(1987, 4, 14),
            ProgramId = 1,
            UserTypeId = 1,
            Address = "666 Pine Lane",
            City = "Anothercity",
            Country = "UK",
            PostalCode = "98765",
            Phone = "666-345-6789",
            Email = "isabella.sophia@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 1,
            FieldOfStudyId = 1
        },
        new User
        {
            Id = 17,
            FirstName = "Oliver",
            MiddleName = "James",
            LastName = "Davis",
            FullName = "Oliver James Davis",
            BirthDay = new DateTime(1992, 1, 31),
            ProgramId = 2,
            UserTypeId = 2,
            Address = "123 Main Lane",
            City = "Anytown",
            Country = "USA",
            PostalCode = "12345",
            Phone = "123-567-8901",
            Email = "oliver.james@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 2,
            FieldOfStudyId = 2
        },
        new User
        {
            Id = 18,
            FirstName = "Sophia",
            MiddleName = "Elizabeth",
            LastName = "Brown",
            FullName = "Sophia Elizabeth Brown",
            BirthDay = new DateTime(1993, 5, 27),
            ProgramId = 3,
            UserTypeId = 3,
            Address = "777 Elm Road",
            City = "Othercity",
            Country = "Canada",
            PostalCode = "54321",
            Phone = "777-234-5678",
            Email = "sophia.elizabeth@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 3,
            FieldOfStudyId = 3
        },
        new User
        {
            Id = 19,
            FirstName = "Liam",
            MiddleName = "Michael",
            LastName = "Wilson",
            FullName = "Liam Michael Wilson",
            BirthDay = new DateTime(1988, 8, 9),
            ProgramId = 4,
            UserTypeId = 1,
            Address = "555 Oak Lane",
            City = "Sometown",
            Country = "USA",
            PostalCode = "98765",
            Phone = "555-567-9012",
            Email = "liam.michael@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 1,
            FieldOfStudyId = 4
        },
        new User
        {
            Id = 20,
            FirstName = "Amelia",
            MiddleName = "Charlotte",
            LastName = "Hernandez",
            FullName = "Amelia Charlotte Hernandez",
            BirthDay = new DateTime(1994, 2, 1),
            ProgramId = 5,
            UserTypeId = 2,
            Address = "666 Maple Road",
            City = "Anothercity",
            Country = "UK",
            PostalCode = "98765",
            Phone = "666-234-5678",
            Email = "amelia.charlotte@example.com",
            Password = "12345",
            CreatedAt = DateTime.Now,
            CreatedBy = "Admin",
            UpdatedAt = DateTime.Now,
            UpdatedBy = "Admin",
            Status = 1,
            FacultyId = 2,
            FieldOfStudyId = 5
        }
    };

            modelBuilder.Entity<User>().HasData(users);
        }

    }
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=DHA-001329;Initial Catalog=SHBDataBase;Integrated Security=True; trustServerCertificate=true");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
