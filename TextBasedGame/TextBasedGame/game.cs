using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Game 
    {
        public static void GameInit()
        {
            Menus.GameMenu();
        }
        public static void GameInfo()
        {
            Console.WriteLine("Potato Entertainment Presents:");
            Console.WriteLine("  ### PlaceHolderName ###");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        public static async void LoadingBar(int lineNr)
        {
            Console.Write("Oooooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("oOoooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("ooOooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("oooOoooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("ooooOooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("oooooOoooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("ooooooOooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("oooooooOoooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("ooooooooOooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("oooooooooOoooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("ooooooooooOooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);
            Console.Write("oooooooooooOoooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(100);

        }
    }
}
