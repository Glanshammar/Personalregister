namespace Personalregister;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write(">> ");
            string input = Console.ReadLine()?.Trim() ?? string.Empty;
            switch (input)
            {
                case "exit":
                    return;
                case "help":
                    Commands.PrintHelp();
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
