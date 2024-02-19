using R7.SnakeAndLadders.Entities;
using R7.SnakeAndLadders.Repositories;

namespace R7.SnakeAndLadders.Services
{
    internal class UserService
    {
        UserRepository repository = new UserRepository();
        public User RegisterUser(string userName, string email, string password)
        {
            User user = new User
            {
                UserName = userName,
                Email = email,
                Password = password
            };
            repository.RegisterUser(user);
            return user;
        }
    }
}
