using System;

namespace singleton
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrimaryPlayer player = PrimaryPlayer.Instance;
            Console.WriteLine($"{player.Name} {player.Level}");
            
            Console.ReadKey();
        }
    }
}