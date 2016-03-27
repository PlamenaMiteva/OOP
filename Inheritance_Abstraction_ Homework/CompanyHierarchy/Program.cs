namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using CompanyHierarchy.Models;

    class Program
    {
        static void Main()
        {
            var manager = new Manager(1, "Ivan", "Ivanov", 5678.43m, Department.Production);
            var developer = new Developer(2, "Nikolay", "Totev", 2999.40m, Department.Production);
            var project = new Project("The best of...", new DateTime(2013, 01, 03), "some details");
            developer.AddProject(project);
            var salesEmployee =new SalesEmployee(3, "Maria", "Iordanova", 1234.56m, Department.Production);
            var sale_1 = new Sale("computer", new DateTime(2015, 03, 20), 2029m);
            var sale_2 = new Sale("laptop", new DateTime(2015, 04, 09), 2038.98m);
            salesEmployee.AddSale(sale_1);
            salesEmployee.AddSale(sale_2);
            var secondSalesEmployee = new SalesEmployee(4, "Martin", "Mitev", 1561.08m, Department.Production);
            var sale_3=new Sale("vacum cleaner", new DateTime(2014, 07, 31), 178.38m);
            var sale_4=new Sale("steam mop", new DateTime(2015, 01, 09), 39.51m);
            secondSalesEmployee.AddSale(sale_3);
            secondSalesEmployee.AddSale(sale_4);
            var secondDeveloper = new Developer(5, "Petar", "Ignatov", 4801.39m, Department.Production);
            var project_1 = new Project("New virtual machine", new DateTime(2014, 01, 09), "some details");
            var project_2 = new Project("Db App Development", new DateTime(2015, 10, 09), "some details");
            project_2.CloseProject();
            secondDeveloper.AddProject(project_1);
            secondDeveloper.AddProject(project_2);
            manager.AddEmployee(developer);
            manager.AddEmployee(salesEmployee);
            manager.AddEmployee(secondSalesEmployee);
            manager.AddEmployee(secondDeveloper);

            var secondManager= new Manager(6, "Ivaylo", "Stanoev", 10957.45m, Department.Marketing);
            var employees = new List<Employee>();
            employees.Add(manager);
            employees.Add(secondManager);
           
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
