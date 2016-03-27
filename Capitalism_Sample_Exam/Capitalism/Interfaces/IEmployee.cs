namespace Capitalism.Interfaces
{   
    using Capitalism.Enums;

    public interface IEmployee 
    {
        string FullName { get; }

        string FirstName { get; }

        string LastName { get; }

        Position Position { get; }

        decimal Salary { get; set; }
    }

    
}
