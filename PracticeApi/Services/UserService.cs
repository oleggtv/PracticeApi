using PracticeApi.Repository;
namespace PracticeApi.Services
{
    public class UserService : IUserService
    {

        //List<User> users = new List<User>()
        //    {
        //        new() {Id = Guid.NewGuid(), UserName = "Oleg", Email = "oleggtv@gmail.com"},
        //        new() {Id = Guid.NewGuid(), UserName = "Andry", Email = "batmangtv@gmail.com"},
        //        new() {Id = Guid.NewGuid(), UserName = "Svitlana", Email = "svetlanagtv@gmail.com"}
        //    };
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public List<User> GetAll()
        {
            var users = _repository.GetAll();
            return users;
        }
        public User GetUser(Guid id)
        {
            var users = _repository.GetAll();
            var user = users?.FirstOrDefault(x => x.Id == id);
            return user;
        }
        public List<User> AddUser(User user)
        {
            user.Id = Guid.NewGuid();
            var users = _repository.GetAll();
            users.Add(user);
            _repository.AddUser(user);
            return users;
        }
        //public List<User> ReplaceUser(User user)
        //{
        //    var users = _repository.GetAll();
        //    var userOld = users?.FirstOrDefault(x => x.Id == user.Id);
        //    if (userOld != null)
        //    {
        //        users?.Remove(userOld);
        //        users?.Add(user);
        //    }
        //    return users;
        //}
        //public List<User> RemoveUser(User user)
        //{
        //    return users;
        //}
    }
}
