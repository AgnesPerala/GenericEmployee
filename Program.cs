using System.Xml.Linq;

namespace GenericEmployee;

internal class Program
{
    static void Main(string[] args)
    {
        // makes 5 objects with the employee class 
        Employee employee1 = new Employee
        {
            Id = 10,
            Name = "agnes",
            Gender = "kvinna",
            Salery = 10000,
        };
        Employee employee2 = new Employee
        {
            Id = 20,
            Name = "jonas",
            Gender = "man",
            Salery = 20000,
        };
        Employee employee3 = new Employee
        {
            Id = 30,
            Name = "Ebba",
            Gender = "kvinna",
            Salery = 30000,
        };
        Employee employee4 = new Employee
        {
            Id = 40,
            Name = "henrik",
            Gender = "man",
            Salery = 40000,
        };
        Employee employee5 = new Employee
        {
            Id = 50,
            Name = "Emelie",
            Gender = "kvinna",
            Salery = 50000,
        };

        Console.WriteLine("--------Stack--------");

        // obejct to stack every employee 
        Stack<Employee> employeeStack = new Stack<Employee>();

        // push method so the employees is in the stack 
        employeeStack.Push(employee1);
        employeeStack.Push(employee2);
        employeeStack.Push(employee3); 
        employeeStack.Push(employee4);
        employeeStack.Push(employee5);

        // print out all employees in the stack 
        foreach (Employee element in employeeStack)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Id: {element.Id}\nNamn: {element.Name}\nKön: {element.Gender}\nSaldo: {element.Salery}");
            Console.WriteLine($"kvar i stacken är: {employeeStack.Count()} \n"); // counting how many is in the stack
        }

        Console.WriteLine("-----pop metoden-----");

        //variable for the loop so it only loops the times the stack size
        int stackSize = employeeStack.Count();
        for (int i = 0; i < stackSize; i++)
        {
            // using the pop method to remove every employee untill its empty
            Employee topEmp = employeeStack.Pop(); 
            Console.WriteLine(" ");
            Console.WriteLine($"Id: {topEmp.Id}\nNamn: {topEmp.Name}\nKön: {topEmp.Gender}\nSaldo: {topEmp.Salery}");
            Console.WriteLine($"kvar i stacken är: {employeeStack.Count()}\n "); // counting down until it's empty
        }

        Console.WriteLine("-----peek metoden-----");

        // return every employee with push method 
        employeeStack.Push(employee1);
        employeeStack.Push(employee2);
        employeeStack.Push(employee3);
        employeeStack.Push(employee4);
        employeeStack.Push(employee5);

        // variable for peek method 
        Employee peekEmp = employeeStack.Peek();

        // print out the first employee in the stack
        Console.WriteLine($"Id: {peekEmp.Id}\nNamn: {peekEmp.Name}\nKön: {peekEmp.Gender}\nSaldo: {peekEmp.Salery}");
        Console.WriteLine($"kvar i stacken är: {employeeStack.Count()}\n ");

        // removes one employee 
        employeeStack.Pop();

        // peek on a new employe after one got removed so it is a new employee first in the stack 
        Employee peekEmp1 = employeeStack.Peek();

        // print out the new employee 
        Console.WriteLine($"Id: {peekEmp1.Id}\nNamn: {peekEmp1.Name}\nKön: {peekEmp1.Gender}\nSaldo: {peekEmp1.Salery}");
        Console.WriteLine($"kvar i stacken är: {employeeStack.Count()}\n ");

        // check if employee 3 is in the stack and prints out answer
        if (employeeStack.Contains(employee3))
        {
            Console.WriteLine("anstäld 3 är i stacken");
        }
        else
        {
            Console.WriteLine("anstäld 3 finns inte i stacken");
        }


        Console.WriteLine("\n--------- List ---------\n");

        // object for a list 
        List<Employee> employees = new List<Employee>();

        // adds every employee to the list 
        employees.Add(employee1);
        employees.Add(employee2);
        employees.Add(employee3);
        employees.Add(employee4);
        employees.Add(employee5);

        // checks if emplyee 4 is in the list and print out answer 
        if (employees.Contains(employee4))
        {
            Console.WriteLine("anstäld 4 finns i listan");
        }
        else
        {
            Console.WriteLine("anstäld 4 finn inte i listan");
        }

        Console.WriteLine("\n---hittar första mannen i listan---\n");

        // using find method to sort out only the mans in the list 
        Employee? findEmp = employees.Find(employeeObject => employeeObject.Gender == "man");

        // checks if there is man in the list and prints out 
        if(findEmp != null)
        {

            Console.WriteLine($"Id: {findEmp.Id}\nNamn: {findEmp.Name}\nKön: {findEmp.Gender}\nSaldo: {findEmp.Salery}");
        }
        else 
        {
            Console.WriteLine("det finns inga killar i listan");
        }

        Console.WriteLine("\n---hittar alla män som finns i listan---");

        // using findall method to print out all men in the list 
        List<Employee> maleEmp = employees.FindAll( employee => employee.Gender == "man");

        // loops through the hole list to find all men in the list 
        foreach (Employee male in maleEmp)
        {
            Console.WriteLine($"\nId: {male.Id}\nNamn: {male.Name}\nKön: {male.Gender}\nSaldo: {male.Salery}");
        }
    }
}