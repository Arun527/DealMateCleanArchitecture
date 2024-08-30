using Authorization.Domain.Aggregates;

namespace Authorization.Interfaces;

public interface IPermissionRepository
{
    Task<Permission> Create(Permission permission);
    Task<Permission> Update(Permission permission);
    Task<Permission> Delete(int id);
}
