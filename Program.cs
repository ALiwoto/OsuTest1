using System;
using Test1.Client;
using osu.Framework;
using osu.Framework.Platform;
using osu.Framework.Graphics.Colour;

namespace Test1
{
    class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"Test1"))
            using (osu.Framework.Game game = new GameClient())
            {
                
                
                //System.Threading.Tasks.Task.Run(() => {
                //    System.Threading.Thread.Sleep(2000);
                //    game.Colour = ColourInfo.SingleColour(SRGBColour.FromVector(new(0, 0, 0, 0)));
                //    game.Width = 10;
                //    game.Height = 10;
                //    game.UpdateSubTree();
                //    host.Window.ClearCurrent();
                //    host.Window.WindowState = WindowState.Minimised;
                //});
                
                host.Run(game);
            }
        }
    }
}
