using Authorization.Domain.Aggregates;
using Authorization.Interfaces;
using DataContext.GenericRepositories;
using Microsoft.AspNetCore.Mvc;

namespace DealMateCleanArchitecture.Controllers.Authorization;

[Route("api/[controller]")]
[ApiController]
public class PermissionController : ControllerBase
{
    private readonly IPermissionRepository permissionRepository;
    private readonly IRepository<Permission> repository;
    public PermissionController(IPermissionRepository permissionRepository, IRepository<Permission> repository)
    {
        this.permissionRepository = permissionRepository;
        this.repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        return Ok(await repository.ListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await repository.GetAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> Create(Permission permission)
    {
        return Ok(await permissionRepository.Create(permission));
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] Permission permission)
    {
        return Ok(await permissionRepository.Update(permission));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await permissionRepository.Delete(id));
    }
}
