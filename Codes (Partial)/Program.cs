using System;
using thirdEntityFramworkTry;

Console.WriteLine("Hello, World!");

using (var context = new ApplicationDbContext())
{

    Console.WriteLine("Enter one of the following:");
    Console.WriteLine("A: Add");
    Console.WriteLine("D: Delete");
    Console.WriteLine("E: Edit (Update)");
    Console.WriteLine("P: Print all");

    string userChoice = Console.ReadLine();
    string userInput;
    switch (userChoice) {
        case "A":
        case "a":
            Console.Write("Enter new name: ");
            userInput = Console.ReadLine();
            var employee1 = new Employee { Name = userInput};
            context.Employees.Add(employee1);
            break;



        case "D":
        case "d":
            Console.Write("Enter the name for the user you want to delete: ");
            userInput = Console.ReadLine();
            var employeeToDelete = context.Employees.FirstOrDefault(c => c.Name == userInput);

            if (employeeToDelete != null)
            {
                // Remove the customer from the context
                context.Employees.Remove(employeeToDelete);

                Console.WriteLine("Employee deleted successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
            break;



        case "E":
        case "e":
            Console.Write("Enter the name of the employee you want to edit: ");
            userInput = Console.ReadLine();
            var employeeToEdit = context.Employees.FirstOrDefault(c => c.Name == userInput);

            if (employeeToEdit != null)
            {
                Console.Write("enter the new name: ");
                string newName = Console.ReadLine();
                employeeToEdit.Name = newName;
                Console.WriteLine("Employee Edited successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
            break;
        case "P":
        case "p":
            // Print all employees
            Console.WriteLine("Wait while printing...");
            Console.WriteLine("Employees:");
            var employees = context.Employees.ToList();
            if (employees.Count > 0)
            {
                
                foreach (var employee in employees)
                {
                    Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}");
                }
            }
            else
            {
                Console.WriteLine("No employees found.");
            }
            break;

        default:
            Console.WriteLine("Invalid choice.");
            break;

    }
    

    
    context.SaveChanges();
}
