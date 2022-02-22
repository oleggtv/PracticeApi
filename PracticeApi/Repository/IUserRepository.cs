﻿namespace PracticeApi.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();
        //User GetUser(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
