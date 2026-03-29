class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Healthcare System");
        Console.WriteLine("2. Banking System");
        Console.WriteLine("3. E-Commerce Order System");
        Console.WriteLine("4. Vehicle Management System");
        Console.WriteLine("5. Education System");
        Console.WriteLine("6. Furniture System");
        Console.Write("Enter choice: ");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Assignment1.Run();
                break;

            case 2:
                Assignment2.Run();
                break;

            case 3:
                Assignment3.Run();
                break;

            case 4:
                Assignment4.Run();
                break;

            case 5:
                Assignment5.Run();
                break;

            case 6:
                Assignment6.Run();
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}