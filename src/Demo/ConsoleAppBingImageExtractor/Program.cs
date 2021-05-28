using BingImageExtractor;
using System;
using System.Threading.Tasks;

namespace ConsoleAppBingImageExtractor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var uri = await new BingImageProcess().GetBingImageAsync();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Bing Image Url: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"'{uri.ToString()}'");
            Console.ResetColor();
        }
    }
}