using System;

namespace AudioExample
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new AudioExampleGame())
                game.Run();
        }
    }
}
