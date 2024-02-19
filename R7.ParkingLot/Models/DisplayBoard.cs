namespace R7.ParkingLot.Models
{
    public class DisplayBoard
    {
        public void Display(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine($"{text}");
            }
        }
    }
}
