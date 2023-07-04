namespace AplicationExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
                {
                new("Ahmed","1234",23),
                new("salim","1122",33),
                new("qais","1122",32)
                };

            Console.WriteLine(Student.ValidatingStudens(students));
        }

    }
}