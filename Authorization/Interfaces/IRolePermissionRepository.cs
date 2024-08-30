using Authorization.Domain.Aggregates;

namespace Authorization.Interfaces;

public interface IRolePermissionRepository
{
    Task<RolePermission> Create(RolePermission rolePermission);
    Task<RolePermission> Update(RolePermission rolePermission);
    Task<RolePermission> Delete(int id);
}
