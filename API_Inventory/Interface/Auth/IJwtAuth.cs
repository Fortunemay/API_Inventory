namespace Inventory_API.Interface.Auth
{
    public interface IJwtAuth
    {
        string Authentication(string employeeId, string email);
    }
}
