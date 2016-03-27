namespace Capitalism.Interfaces
{
    using Capitalism.Models;

    public interface IDepartmentFactory
    {
        Department CreateDepartment(string departmentName, IEmployee manager);
    }
}
