using System.Security.Cryptography.X509Certificates;

namespace Switch
{
    public class Program
    {
        public enum Color
        {
            Red,
            Green, 
            Blue,
            Yellow,
            black,
            white
        }
        static void Main(string[] args)
        {

            Color c = (Color)(new Random().Next(0, 5));

            switch (c)
            {
                case Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Color is Red");
                    break;
                case Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Color is green");
                    break;
                case Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Color Blue");
                    break;
                case Color.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Color yellow");
                    break;
                default:
                    Console.ResetColor();
                    Console.WriteLine("Color reset");
                    break;
            }
        }
    }
}
