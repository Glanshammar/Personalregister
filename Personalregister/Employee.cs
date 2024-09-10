public class Employee{
    private static string firstName;
    private static string lastName;
    private static Int32 salary;

    Employee(string firstName, string lastName, Int32 salary)
    {
        firstName = firstName;
        lastName = lastName;
        salary = salary;
    }

    public static void PrintEmployee()
    {
        Console.WriteLine("\nEmployee Information:");
        Console.WriteLine("First Name: {0}", firstName);
    }
}