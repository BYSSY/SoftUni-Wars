using System;

namespace SoftUniWarz
{

    public static class Program
    {

        [STAThread]
        static void Main()
        {
            using (var game = new UnSeriousEngine())
                game.Run();
        }
    }
}
