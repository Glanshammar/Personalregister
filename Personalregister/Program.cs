namespace Personalregister;

class Program
{
    public static void PrintHelp()
    {
        Console.WriteLine("Commands:");
        Console.WriteLine("  list   - List all employees.");
        Console.WriteLine("  add    - Add employee to the system.");
        Console.WriteLine("  exit   - Exit the program.");
    }
    
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write(">> ");
            string input = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
            switch (input)
            {
                case "exit":
                    return;
                case "help":
                    PrintHelp();
                    break;
                case "list":
                    Commands.ListEmployees();
                    break;
                case "add":
                    Commands.AddEmployee();
                    break;
                default:
                    Console.WriteLine("Unknown command. Type 'help' for a list of commands.");
                    break;
            }
        }
    }
}
