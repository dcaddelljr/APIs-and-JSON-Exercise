using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
     
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"KANYE QUOTE: {Quotes.KanyeQuote()}\n\nRON SWANSON QUOTE: {Quotes.RonQuote()}\n");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Joke funny.\nFunny laugh.\nLaugh ha.\nHa Ha Ha!");
            Console.WriteLine();
        }
    }
}
