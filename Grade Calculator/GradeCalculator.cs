namespace DCIT_318_Project
{
    internal class GradeCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grade Calculator ===");



            while (true)
            {
                try
                {
                    Console.Write("Enter your numerical grade (0 - 100): ");
                    string input = Console.ReadLine();

                    int grade = Convert.ToInt32(input);


                    if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Error: Grade must be between 0 and 100.");
                        continue;
                    }

                    else
                    {
                        char letterGrade;

                        if (grade >= 90)
                            letterGrade = 'A';
                        else if (grade >= 80)
                            letterGrade = 'B';
                        else if (grade >= 70)
                            letterGrade = 'C';
                        else if (grade >= 60)
                            letterGrade = 'D';
                        else
                            letterGrade = 'F';

                        Console.WriteLine($"Your letter grade is: {letterGrade}");
                    }
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter a number........");
                    Console.WriteLine(e.Message);
                }


            }
        }
    }
}