using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class SentryTools
    {
        public static async void LoadingBar(int lineNr, int loadingDelay)
        {
            Console.Write("Oooooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("oOoooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("ooOooooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("oooOoooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("ooooOooooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("oooooOoooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("ooooooOooooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("oooooooOoooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("ooooooooOooooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("oooooooooOoooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("ooooooooooOooooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);
            Console.Write("oooooooooooOoooo");
            Console.SetCursorPosition(1, lineNr);
            await Task.Delay(loadingDelay);

        }

        public static void Quit()
        {
            Environment.Exit(0);
            return;
        }
    }
}
