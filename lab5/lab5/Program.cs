
public class Program
{
    public static void Main()
    {
        List<Planet> planets = new List<Planet>
        {
            new Mars(),
            new Venus(),
            new Mercury(),
            new Jupiter(),
            new Saturn(),
            new Uranus(),
            new Neptune()
        };

        List<Student> students = new List<Student>
        {
            new Student("Alice", 12, 80),
            new Student("Bob", 8, 65),
            new Student("Charlie", 25, 95)
        };

        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student.Name}");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet.Check(student));
            }
            Console.WriteLine();
        }
    }
}