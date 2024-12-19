using IntroBuiltInInterfacesAndLINQ.Models;

namespace IntroBuiltInInterfacesAndLINQ.Utilities;

public static class StudentGenerator
{
    public static IEnumerable<Student> GenerateStudents()
    {
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Magnus Olsen", Age = 21, City = "Oslo", EnrolledDate = new DateTime(2023, 8, 15) },
            new Student { Id = 2, Name = "Ingrid Larsen", Age = 23, City = "Bergen", EnrolledDate = new DateTime(2022, 1, 10) },
            new Student { Id = 3, Name = "Erik Hansen", Age = 19, City = "Trondheim", EnrolledDate = new DateTime(2023, 8, 15) },
            new Student { Id = 4, Name = "Sofia Andersen", Age = 20, City = "Stavanger", EnrolledDate = new DateTime(2023, 1, 12) },
            new Student { Id = 5, Name = "Lars Pedersen", Age = 22, City = "Tromsø", EnrolledDate = new DateTime(2022, 8, 16) },
            new Student { Id = 6, Name = "Astrid Nilsen", Age = 21, City = "Oslo", EnrolledDate = new DateTime(2022, 8, 16) },
            new Student { Id = 7, Name = "Henrik Johansen", Age = 24, City = "Bergen", EnrolledDate = new DateTime(2021, 8, 17) },
            new Student { Id = 8, Name = "Emma Kristiansen", Age = 20, City = "Trondheim", EnrolledDate = new DateTime(2023, 1, 12) },
            new Student { Id = 9, Name = "Jonas Berg", Age = 19, City = "Stavanger", EnrolledDate = new DateTime(2023, 8, 15) },
            new Student { Id = 10, Name = "Nora Haugen", Age = 22, City = "Oslo", EnrolledDate = new DateTime(2022, 1, 10) },
            new Student { Id = 11, Name = "Anders Pettersen", Age = 23, City = "Bergen", EnrolledDate = new DateTime(2021, 1, 11) },
            new Student { Id = 12, Name = "Mia Solberg", Age = 21, City = "Tromsø", EnrolledDate = new DateTime(2022, 8, 16) },
            new Student { Id = 13, Name = "Thomas Moen", Age = 20, City = "Trondheim", EnrolledDate = new DateTime(2023, 1, 12) },
            new Student { Id = 14, Name = "Julie Dahl", Age = 22, City = "Oslo", EnrolledDate = new DateTime(2022, 1, 10) },
            new Student { Id = 15, Name = "Kristian Bakken", Age = 19, City = "Stavanger", EnrolledDate = new DateTime(2023, 8, 15) }
        };

        return students;
    }
}