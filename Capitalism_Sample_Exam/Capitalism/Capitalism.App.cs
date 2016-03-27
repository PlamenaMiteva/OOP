using Capitalism.Models;
using Capitalism.Models.Factories;
using Capitalism.Models.IO;

namespace Capitalism
{
    class Program
    {
        static void Main()
        {
            var companyFactory = new CompanyFactory();
            var departmentFactory = new DepartmentFactory();
            var employeeFactory = new EmployeeFactory();
            var ceoFactory = new CeoFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new Data();

            var engine = new Engine(companyFactory, departmentFactory, ceoFactory,employeeFactory, data, reader, writer);
            engine.Run();
        }
    }
}
