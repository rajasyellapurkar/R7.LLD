namespace R7.SnakeAndLadders.Entities
{
    public class User
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public byte[] ProfilePic { get; set; } = null!;
    }
}
