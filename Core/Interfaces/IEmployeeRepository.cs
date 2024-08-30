using Core.Domain.Aggregates;

namespace Core.Interfaces;

public interface IEmployeeRepository
{
    Task<Employee> Create(Employee employee);
    Task<Employee> Update(Employee employee);
    Task<Employee> Delete(int id);
    Task<string> LogIn(string email, string password);
    Task<Employee> ChangePassword(string email, string password);
}
