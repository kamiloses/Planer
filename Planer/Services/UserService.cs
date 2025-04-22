using Planer.Dtos;

namespace Planer.Services;

public class UserService
{
    private Dictionary<int, UserDto> users = new Dictionary<int, UserDto>();
    private int id = 0;

    public void AddUser(UserDto user)
    {
        id++;
        user.HashedPassword=user.GetHashCode().ToString();
        users.Add(id, user);
    }

    public List<UserDto> ShowAllUsers()
    {
        return users.Values.ToList();
    }
    
    
}