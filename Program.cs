namespace ChallengeLabsWeek2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();

            student1.RollNumber = 784;
            student1.Name = "James";
            student1.Physics = 70;
            student1.Chemestry = 80;
            student1.ComputerApplication = 90;
            student1.Division = "First";
            
            Console.WriteLine($"Roll No: {student1.RollNumber}");
            Console.WriteLine($"Name of Student: {student1.Name}");
            Console.WriteLine($"Marks in Physics: {student1.Physics}");
            Console.WriteLine($"Marks in Chemestry: {student1.Chemestry}");
            Console.WriteLine($"Marks in Computer Application: {student1.ComputerApplication}");
            Console.WriteLine($"Total Marks: {student1.TotalMarks()}");
            Console.WriteLine($"Percentage: {student1.Percentage()}");
            Console.WriteLine($"Division: {student1.Division}");
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string? Name { get; set; }
        public double Physics { get; set; }
        public double Chemestry { get; set; }
        public double ComputerApplication { get; set; }
        public string? Division { get; set; }

        public double TotalMarks()
        {
            double totalMarks = 0;

            totalMarks = Physics + Chemestry + ComputerApplication;
            return totalMarks;
        }

        public double Percentage()
        {
            double percentage = 0;

            percentage = TotalMarks() / 3;
            return percentage;
        }
    }
}
