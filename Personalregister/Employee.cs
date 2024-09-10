namespace Personalregister;

public class Employee{
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private Int32 Salary { get; set; }

    public Employee(string firstName, string lastName, int salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public void PrintEmployee()
    {
        Console.WriteLine($"\nName: {FirstName} {LastName}");
        Console.WriteLine($"Salary: {Salary}kr");
    }
}