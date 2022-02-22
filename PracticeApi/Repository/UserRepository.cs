namespace PracticeApi.Repository
{
    public class UserRepository : IUserRepository
    {
        List<User> users = new List<User>()
            {
                new() {Id = Guid.NewGuid(), UserName = "Oleg", Email = "oleggtv@gmail.com"},
                new() {Id = Guid.NewGuid(), UserName = "Andry", Email = "batmangtv@gmail.com"},
                new() {Id = Guid.NewGuid(), UserName = "Svitlana", Email = "svetlanagtv@gmail.com"}
            };

        public List<User> GetAll()
        {
            return users;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
