using System.Threading.Channels;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gamesList = new List<string>();
            gamesList.Add("The Legend of Zelda");
            gamesList.Add("Donkey Kong");
            gamesList.Add("Super Mario Bros.");
            gamesList.Add("Tetris");
            gamesList.Add("Excitebike");
            gamesList.Add("Pac-Man");
            gamesList.Add("Cuck Hunt");

            gamesList.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
