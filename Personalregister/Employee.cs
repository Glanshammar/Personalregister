namespace Personalregister;

public class Employee{
    private string firstName;
    private string lastName;
    private Int32 salary;

    public Employee(string firstName, string lastName, Int32 salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }

    public void PrintEmployee()
    {
        Console.WriteLine($"\nName: {firstName} {lastName}");
        Console.WriteLine($"Salary: {salary}kr");
    }
}