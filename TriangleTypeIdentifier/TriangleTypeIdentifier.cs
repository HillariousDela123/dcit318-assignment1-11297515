namespace TriangleTypeIdentifier
{
    internal class TriangleTypeIdentifier
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Triangle Type Identifier ===");

            Console.Write("Enter length of side 1: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter length of side 2: ");
            string input2 = Console.ReadLine();

            Console.Write("Enter length of side 3: ");
            string input3 = Console.ReadLine();

            if (double.TryParse(input1, out double side1) &&
                double.TryParse(input2, out double side2) &&
                double.TryParse(input3, out double side3))
            {
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    Console.WriteLine("Error: All side lengths must be positive numbers.");
                }
                else if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                {
                    Console.WriteLine("Error: The given sides do not form a valid triangle.");
                }
                else
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        Console.WriteLine("This is an Equilateral triangle.");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("This is an Isosceles triangle.");
                    }
                    else
                    {
                        Console.WriteLine("This is a Scalene triangle.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for all sides.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
