using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Search Student");
            Console.WriteLine("2. Delete Student");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nEnter Name or National ID to search (type 'cancel' to return):");
                string input = Console.ReadLine();

                if (input.Equals("cancel", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Returning to the Main Menu...");
                    continue; // Go back to the main menu
                }

                // Perform search logic here...
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nEnter National ID to delete (type 'cancel' to return):");
                string input = Console.ReadLine();

                if (input.Equals("cancel", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Returning to the Main Menu...");
                    continue; // Go back to the main menu
                }

                // Perform delete logic here...
            }
            else if (choice == "3")
            {
                Console.WriteLine("Exiting the application. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}

