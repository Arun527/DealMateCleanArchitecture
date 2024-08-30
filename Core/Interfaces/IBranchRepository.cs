using Core.Domain.Aggregates;

namespace Core.Interfaces;

public interface IBranchRepository
{
    Task<Branch> Create(Branch branch);
    Task<Branch> Update(Branch branch);
    Task<Branch> Delete(int id);
}
