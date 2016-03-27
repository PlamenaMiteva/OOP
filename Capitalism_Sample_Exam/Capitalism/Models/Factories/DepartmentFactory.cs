namespace Capitalism.Models.Factories
{
    using Capitalism.Interfaces;

    public class DepartmentFactory: IDepartmentFactory
    {
        public Department CreateDepartment(string departmentName, IEmployee manager)
        {
            var department = new Department(departmentName, manager );
            return department;
        }
    }
}
