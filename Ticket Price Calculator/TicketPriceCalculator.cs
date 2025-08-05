namespace DCIT_318_Project
{
    internal class TicketPriceCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ticket Price Calculator ===");

            int fullPrice = 10;
            int discountPrice = 7;

            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age <= 12 || age >= 65)
                {
                    Console.WriteLine($"You qualify for a discount.");
                    Console.WriteLine($"Your ticket price is: GHC{discountPrice}");
                }
                else
                {
                    Console.WriteLine($"Your ticket price is: GHC{fullPrice}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for age.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}