namespace OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ======= PART 1 - STACK ======= // 

            // EMPLOYEE-CLASS: Adding five new objects from the employee-class. //

            Employee employeeOne = new Employee(110, "Anna Clean", Gender.Female, 37500);
            Employee employeeTwo = new Employee(111, "Bert Moneyprinter", Gender.Male, 55430);
            Employee employeeThree = new Employee(112, "Sally Bigboss", Gender.Female, 97500);
            Employee employeeFour = new Employee(113, "Philip Coffeemaker", Gender.Male, 41500);
            Employee employeeFive = new Employee(114, "Rupert Underdog", Gender.Male, 27500);

            // STACK-PUSH: New stack for the employees and pushing them into the stack. //

            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employeeOne);
            employeeStack.Push(employeeTwo);
            employeeStack.Push(employeeThree);
            employeeStack.Push(employeeFour);
            employeeStack.Push(employeeFive);

            // STACK-PRINT: Printing out every employee in the stack. // 

            Console.WriteLine("Employee list:\n");
            foreach (var employee in employeeStack)
            {
                Console.WriteLine($"ID: {employee.Id} - " +
                    $"Name: {employee.Name} - " +
                    $"Gender: {employee.Gender} - " +
                    $"Salary: {employee.Salary} \n" +
                    $"Employees left in the stack: {employeeStack.Count}.");
            }

            // STACK-POP: Using the pop-method to print every item in the stack. Stores the returned value in a new employee variable. Using the While-iteration since the employeeStack.Count reduces on every iteration from Pop-method. //

            Console.WriteLine("\nRetrieve using Pop Method:\n");
            while (employeeStack.Count > 0)
            {
                Employee employeePop = employeeStack.Pop();
                Console.WriteLine($"ID: {employeePop.Id} - " +
                    $"Name: {employeePop.Name} - " +
                    $"Gender: {employeePop.Gender} - " +
                    $"Salary: {employeePop.Salary} \n" +
                    $"Employees left in the stack: {employeeStack.Count}.");
            }

            // STACK-PUSH: Pushing them into the stack again. //

            employeeStack.Push(employeeOne);
            employeeStack.Push(employeeTwo);
            employeeStack.Push(employeeThree);
            employeeStack.Push(employeeFour);
            employeeStack.Push(employeeFive);

            // PEEK 1: Checking on the top person without removing it. //

            Console.WriteLine("\nRetrieve using Peek Method:\n");
            Employee employeePeek = employeeStack.Peek();
            Console.WriteLine($"ID: {employeePeek.Id} - " +
            $"Name: {employeePeek.Name} - " +
            $"Gender: {employeePeek.Gender} - " +
            $"Salary: {employeePeek.Salary} \n" +
            $"Employees left in the stack: {employeeStack.Count}.");

            // PEEK 2: Doing it again with peek-method. //

            Employee employeePeekTwo = employeeStack.Peek();
            Console.WriteLine($"ID: {employeePeekTwo.Id} - " +
            $"Name: {employeePeekTwo.Name} - " +
            $"Gender: {employeePeekTwo.Gender} - " +
            $"Salary: {employeePeekTwo.Salary} \n" +
            $"Employees left in the stack: {employeeStack.Count}.");

            // CHECK EMPLOYEE THREE: Check if employee three is in the stack. //

            if (employeeStack.Contains(employeeThree))
            {
                Console.WriteLine("\nEmployee Check Number Three:\n" +
                "Employee Number Three is in the stack.");
            }
            else
            {
                Console.WriteLine("\nEmployee Check Number Three:\n" +
                "Employee Number Three wasnt found in the stack.");
            }

            // ======= PART 2 - LIST ======= // 

            // LIST: New list and adding the objects from the Employee-class. //

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employeeOne);
            employeeList.Add(employeeTwo);
            employeeList.Add(employeeThree);
            employeeList.Add(employeeFour);
            employeeList.Add(employeeFive);

            // CHECK OBJECT TWO: Checking for object two in Employee-list. Using a bool-variable for future usage. // 

            bool employeeCheckTwo = employeeList.Contains(employeeTwo);
            if (employeeCheckTwo)
            {
                Console.WriteLine("\nEmployee Check Number Two:\n" +
                    "Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("\nEmployee Check Number Two:\n" +
                    "Employee2 object does not exist in the list");
            }

            // PRINT FIRST MALE: Checking after the first male in the list and printing it out. //

            Employee firstMale = employeeList.Find(employee => employee.Gender == Gender.Male);
            Console.WriteLine($"\nFirst male in the list is:\n" +
            $"ID: {firstMale.Id} - " +
            $"Name: {firstMale.Name} - " +
            $"Gender: {firstMale.Gender} - " +
            $"Salary: {firstMale.Salary} \n");

            // PRINT ALL MALES: Checking for all males. Creating a new list with FindAll-method for the male-genders. //

            List<Employee> maleEmployees = employeeList.FindAll(employee => employee.Gender == Gender.Male);
            Console.WriteLine("All males in the list:\n");
            foreach (Employee males in maleEmployees)
            {
                Console.WriteLine($"ID: {males.Id} - " +
                    $"Name: {males.Name} - " +
                    $"Gender: {males.Gender} - " +
                    $"Salary: {males.Salary}");
            }
        }
    }
}
