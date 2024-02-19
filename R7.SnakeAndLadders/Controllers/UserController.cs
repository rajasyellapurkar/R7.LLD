using R7.SnakeAndLadders.Services;

namespace R7.SnakeAndLadders.Controllers
{
    public class UserController
    {
        UserService userService = new UserService();
        public void RegisterUser(string userName, string email, string password)
        {
            userService.RegisterUser(userName, email, password);
            Console.WriteLine("User saved successfully");
        }
    }
}
