namespace PracticeApi.Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetUser(Guid id);
        //List<User> GetUsersByName(string userName);
        List<User> AddUser(User user);
        //List<User> ReplaceUser(User user);
        //List<User> RemoveUser(User user);
    }
}
