using IntroBuiltInInterfacesAndLINQ.Enumerables;
using IntroBuiltInInterfacesAndLINQ.Models;
using IntroBuiltInInterfacesAndLINQ.Utilities;

namespace IntroBuiltInInterfacesAndLINQ.Demos
{
    public class LinqDemo : IDemo
    {
        private IEnumerable<Student> _students = StudentGenerator.GenerateStudents();

        public DemoName Name => DemoName.Linq;

        public void Run()
        {
            // Find all students below or equal 20?
            var studentsAge20OrBelow = _students.Where(x => x.Age <= 20);
            // Find all students in Trondheim?
            var studentsInTrondheim = _students.Where(x => x.City == "Trondheim");

            // Find the first enrolled student?
            var firstEnrolledStudent = _students.OrderBy(x => x.EnrolledDate).First();
            // Find by id?
            var studentById = _students.FirstOrDefault(x => x.Id == 1);
            // Average age?
            var averageAge = _students.Average(x => x.Age);

            // Cities with most students?
            var cityWithMostStudents = _students
                .GroupBy(x => x.City)
                .OrderByDescending(x => x.Count())
                .Select(x => new { City = x.Key, Count = x.Count() });

            // Are there any students from Sandefjord?
            var anyoneFromSandefjord = _students.Any(x => x.City == "Sandefjord");

            var everyoneFromOslo = _students.All(x => x.City == "Oslo");
            // Students in "random" order?
            var randomizedStudents = _students.OrderBy(x => Guid.NewGuid());
        }
    }
}