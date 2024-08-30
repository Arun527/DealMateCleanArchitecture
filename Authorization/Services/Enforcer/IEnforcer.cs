namespace Authorization.Services.Enforcer;

public interface IEnforcer
{
    Task EnforceAsync(string permission);
}
