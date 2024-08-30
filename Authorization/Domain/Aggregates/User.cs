namespace Authorization.Domain.Aggregates;

public class User
{
    public User(int id, string name, int roleId, string email)
    {
        Id = id;
        Name = name;
        RoleId = roleId;
        Email = email;
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int RoleId { get; set; }
    public string Email { get; set; } = null!;
}
