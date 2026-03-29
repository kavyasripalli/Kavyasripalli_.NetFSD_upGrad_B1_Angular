namespace C__Basic_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Welcome Message");
            Console.WriteLine("2. Greet User (Command Line)");
            Console.WriteLine("3. Numbers between two values (Command Line)");
            Console.WriteLine("4. Odd or Even");
            Console.WriteLine("5. Count Odd and Even Numbers");
            Console.WriteLine("6. Fahrenheit to Celsius");
            Console.WriteLine("7. Shopkeeper Billing System");
            Console.WriteLine("8. Square Series (0 to 625)");
            Console.WriteLine("9. Factorial of a Number");
            Console.WriteLine("10. Fibonacci Series (till 40)");
            Console.WriteLine("11. Multiplication Table (till 20)");
            Console.WriteLine("12. Numbers divisible by 7 (200–300)");
            Console.WriteLine("13. Largest of Three Numbers");
            Console.WriteLine("14. Smallest of Five Numbers");
            Console.WriteLine("15. Marks Analysis System");
            Console.WriteLine("16. Length of a Word");
            Console.WriteLine("17. Reverse a Word");
            Console.WriteLine("18. Compare Two Words");
            Console.WriteLine("19. Palindrome Check");

            int choice;

            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            switch (choice)
            {
                case 1:
                    Exercise1.Run();
                    break;

                case 2:
                    Exercise2.Run(args);
                    break;

                case 3:
                    Exercise3.Run(args);
                    break;

                case 4:
                    Exercise4.Run();
                    break;

                case 5:
                    Exercise5.Run();
                    break;

                case 6:
                    Exercise6.Run();
                    break;

                case 7:
                    Exercise7.Run();
                    break;

                case 8:
                    Exercise8.Run();
                    break;

                case 9:
                    Exercise9.Run();
                    break;

                case 10:
                    Exercise10.Run();
                    break;

                case 11:
                    Exercise11.Run();
                    break;

                case 12:
                    Exercise12.Run();
                    break;

                case 13:
                    Exercise13.Run();
                    break;

                case 14:
                    Exercise14.Run();
                    break;

                case 15:
                    Exercise15.Run();
                    break;

                case 16:
                    Exercise16.Run();
                    break;

                case 17:
                    Exercise17.Run();
                    break;

                case 18:
                    Exercise18.Run();
                    break;

                case 19:
                    Exercise19.Run();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
