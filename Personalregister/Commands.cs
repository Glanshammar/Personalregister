namespace Personalregister;

public class Commands
{
    static List<Employee> employees = new List<Employee>();
    
    public static void ListEmployees()
    {
        if (!employees.Any())
        {
            Console.WriteLine("There are no employees in the system.");
            return;
        }
    
        Console.WriteLine("\n--- Employee List ---");
        foreach (var employee in employees)
        {
            employee.PrintEmployee();
        }
        Console.WriteLine($"\nTotal employees: {employees.Count}");
    }
    
    public static void AddEmployee()
    {
        string firstName, lastName;
        int salary;

        do
        {
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine()?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("First name cannot be empty. Please try again.");
            }
        } while (string.IsNullOrWhiteSpace(firstName));

        do
        {
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine()?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Last name cannot be empty. Please try again.");
            }
        } while (string.IsNullOrWhiteSpace(lastName));

        bool validSalary = false;
        do
        {
            Console.Write("Enter salary: ");
            string salaryInput = Console.ReadLine() ?? string.Empty;
            if (Int32.TryParse(salaryInput, out salary))
            {
                if (salary > 0)
                {
                    validSalary = true;
                }
                else
                {
                    Console.WriteLine("Salary must be a whole, positive number. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (!validSalary);

        employees.Add(new Employee(firstName, lastName, salary));
        Console.WriteLine("Employee added successfully.");
    }
}