using System;

class Assignment2
{
    static void Main(string[] args)
    {
        int availableTickets = 15;

        Console.Write("Do you want to book tickets? (yes/no): ");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "yes")
        {
            Console.Write("Enter number of tickets: ");
            int tickets = int.Parse(Console.ReadLine());

            try
            {
                if (tickets > availableTickets)
                {
                    throw new Exception("Not enough tickets available");
                }

                availableTickets -= tickets;

                Console.WriteLine("Tickets booked successfully");
                Console.WriteLine("Remaining tickets: " + availableTickets);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Booking cancelled");
        }
    }
}