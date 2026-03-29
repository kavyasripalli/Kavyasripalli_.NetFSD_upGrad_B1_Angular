using System;

public class Exercise7
{
    public static void Run()
    {
        int n, product, quantity;
        double price = 0, total = 0;

        Console.Write("Enter number of items: ");

        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter product number (1-3): ");
            product = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            switch (product)
            {
                case 1:
                    price = 22.5;
                    break;

                case 2:
                    price = 44.50;
                    break;

                case 3:
                    price = 9.98;
                    break;

                default:
                    Console.WriteLine("Invalid product number");
                    i--; // retry
                    continue;
            }

            total += price * quantity;
        }

        Console.WriteLine("Total Bill = " + total);
    }
}