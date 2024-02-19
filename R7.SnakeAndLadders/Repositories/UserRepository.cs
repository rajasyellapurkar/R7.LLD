using R7.SnakeAndLadders.Entities;

namespace R7.SnakeAndLadders.Repositories
{
    public class UserRepository
    {
        private List<User> _users = new List<User>();

        public User RegisterUser(User user)
        {
            _users.Add(user);
            return user;
        }
    }
}
