namespace OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adding five new objects from the employee-class. //

            Employee employeeOne = new Employee(110,"Anna Clean", Gender.Female, 37500);
            Employee employeeTwo = new Employee(111, "Bert Moneyprinter", Gender.Male, 55430);
            Employee employeeThree = new Employee(112, "Sally Bigboss", Gender.Female, 97500);
            Employee employeeFour = new Employee(113, "Philip Coffeemaker", Gender.Male, 41500);
            Employee employeeFive = new Employee(114, "Rupert Underdog", Gender.Male, 27500);

            // New stack for the employees and pushing them into the stack. //

            Stack<Employee> EmployeeStack = new Stack<Employee>();
            EmployeeStack.Push(employeeOne);
            EmployeeStack.Push(employeeTwo);
            EmployeeStack.Push(employeeThree);
            EmployeeStack.Push(employeeFour);
            EmployeeStack.Push(employeeFive);

            // Printing out every employee in the stack. // 

            Console.WriteLine("Employee list:\n");
            foreach (var employee in EmployeeStack)
            {
                Console.WriteLine($"ID: {employee.Id} - " +
                    $"Name: {employee.Name} - " +
                    $"Gender: {employee.Gender} - " +
                    $"Salary: {employee.Salary} \n" +
                    $"Employees left in the stack: {EmployeeStack.Count}.");
            }

            // Using the pop-method to print every item in the stack. Stores the returned value in a new employee object. 
            // Using a while-iteration since the Employeelist.Count reduces on every iteration. 

            Console.WriteLine("\nRetrieve using Pop Method:\n");
            while (EmployeeStack.Count > 0) 
            {
                Employee employeePop = EmployeeStack.Pop();
                Console.WriteLine($"ID: {employeePop.Id} - " +
                    $"Name: {employeePop.Name} - " +
                    $"Gender: {employeePop.Gender} - " +
                    $"Salary: {employeePop.Salary} \n" +
                    $"Employees left in the stack: {EmployeeStack.Count}.");
            }

            // Pushing them into the stack again. //
            EmployeeStack.Push(employeeOne);
            EmployeeStack.Push(employeeTwo);
            EmployeeStack.Push(employeeThree);
            EmployeeStack.Push(employeeFour);
            EmployeeStack.Push(employeeFive);

            // Peek-method Object 1.

            Console.WriteLine("\nRetrieve using Peek Method:\n");
            
            Employee employeePeek = EmployeeStack.Peek();
            Console.WriteLine($"ID: {employeePeek.Id} - " +
            $"Name: {employeePeek.Name} - " +
            $"Gender: {employeePeek.Gender} - " +
            $"Salary: {employeePeek.Salary} \n" +
            $"Employees left in the stack: {EmployeeStack.Count}.");

            // Peek-method Object 2.

            Employee employeePeekTwo = EmployeeStack.Peek();
            Console.WriteLine($"ID: {employeePeekTwo.Id} - " +
            $"Name: {employeePeekTwo.Name} - " +
            $"Gender: {employeePeekTwo.Gender} - " +
            $"Salary: {employeePeekTwo.Salary} \n" +
            $"Employees left in the stack: {EmployeeStack.Count}.");

            // Check if employee three is in the stack. 

            if (EmployeeStack.Count >= 3)
            {
                Console.WriteLine("Employee Number Three is in the stack.");
            }
            else
            {
                Console.WriteLine("Employee Number Three wasnt found in the stack.");
            }

        }
    }
}
