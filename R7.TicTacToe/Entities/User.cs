namespace R7.TicTacToe.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte[] ProfilePic { get; set; } = new byte[0];
    }
}
