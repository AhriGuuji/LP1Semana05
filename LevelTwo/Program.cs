using System;
using Spectre.Console;
using SoGoodLib;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SoGoodClass.SoGoodMethod());
            CanvasImage image = new CanvasImage(args[0]);
            image.MaxWidth(int.Parse(args[1]));
            if (args[0] == null )
            {
                image = new CanvasImage("tux.jpg");
                image.MaxWidth(24);
                AnsiConsole.Write(image);
            }
            else 
            {
                AnsiConsole.Write(image);
            }
        }
    }
}
