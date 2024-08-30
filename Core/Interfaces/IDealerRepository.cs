using Core.Domain.Aggregates;

namespace Core.Interfaces;

public interface IDealerRepository
{
    Task<Dealer> Create(Dealer dealer);
    Task<Dealer> Update(Dealer dealer);
    Task<Dealer> Delete(int id);
}

