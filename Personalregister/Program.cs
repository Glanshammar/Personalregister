namespace Personalregister;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write(">> ");
            string input = Console.ReadLine() ?? string.Empty;
            if (input == "exit")
            {
                break;
            }

            if (input == "help")
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("  list - list all employees.");
                Console.WriteLine("  add - add employee to the system.");
                Console.WriteLine("  exit - exit the program.");
            }
            else if (input.ToLower() == "list")
            {
                Commands.ListEmployees();
            }
            else if (input.ToLower() == "add")
            {
                Commands.AddEmployee();
            }
        }
    }
}
