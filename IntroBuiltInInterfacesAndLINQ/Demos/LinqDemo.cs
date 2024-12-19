using IntroBuiltInInterfacesAndLINQ.Enumerables;
using IntroBuiltInInterfacesAndLINQ.Models;
using IntroBuiltInInterfacesAndLINQ.Utilities;

namespace IntroBuiltInInterfacesAndLINQ.Demos
{
    public class LinqDemo : IDemo
    {
        private IEnumerable<Student> _students = StudentGenerator.GenerateStudents();
        public void Run()
        {
            
            // Find all students above a certain age?
            // Find all students in Trondheim?
            // Find the first enrolled student?
            // Find by id?
            // Average age?

      
            // var numbers = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            // FilterDemo(numbers);
            // MappingDemo(numbers);
            // CombinedDemo(numbers);
            // // mapping, projeksjon
            // // reversering
            // var reversedNumbers = numbers.Reverse();
            // // sortering
            // var orderedNumbers = numbers.OrderBy(n => n);
            // // gruppering
            // // aggregeringer: sum, gjennomsnitt, antall
            // AggregateDemo(numbers);
            // // søk: er elementet med? finn elementet
            // SearchDemo(numbers);

        }

        private IEnumerable<Student> FilterStudentsByMinimumAge(int minimumAge)
        {
            return _students.Where(student => student.Age >= minimumAge);
        }

        private void SearchDemo(int[] numbers)
        {
            // har numbers elementet 7
            var has7 = numbers.Contains(7);
            var hasBelow10 = numbers.Any(n => n < 10);

            var firstBelow10a = numbers.FirstOrDefault(n=>n<10);
            var firstBelow10b = numbers.SingleOrDefault(n=>n<10);
        }

        private void CombinedDemo(int[] numbers)
        {
            // med variabler
            var tripledNumbers = numbers.Select(n => n * 3);
            var filteredNumbers = tripledNumbers.Where(n => n is > 10 and < 100);
            var sum = filteredNumbers.Sum();

            // kjedede kall
            var sumB = numbers
                .Select(n => n * 3)
                .Where(n => n is > 10 and < 100)
                .Sum();
        }

        private void AggregateDemo(int[] numbers)
        {
            var sum = numbers.Sum();
            var average = numbers.Average();
            var max = numbers.Max();
        }

        private void MappingDemo(int[] numbers)
        {
            // mapping JS: numbers.map(n=>`<li>${n}</li>`)

            var html = "";
            foreach (var number in numbers)
            {
                html += $"<li>${number}</li>";
            }

            var htmlElements = numbers.Select(n => $"<li>${n}</li>");
            var htmlB = string.Join("", htmlElements);
        }

        private void FilterDemo(int[] numbers)
        {
            // filtrering JS: numbers.filter(n=>n> 10 && n<100)

            // uten LINQ
            var numbersBetween10And100 = new List<int>();
            foreach (var number in numbers)
            {
                if (number > 10 && number < 100)
                {
                    numbersBetween10And100.Add(number);
                }
            }

            // med LINQ - med lambda og uten
            var numbersBetween10And100b = numbers.Where(n => n is > 10 and < 100);
            var numbersBetween10And100c = numbers.Where(NumberUtilities.IsBetween10And100);

            // eksempel på at Where kan brukes på alt som implementerer IEnumerable
            var numberSequence = new DoublingNumberSequence(1, 1000);
            numberSequence.Where(n => n < 100);
        }
    }
}
