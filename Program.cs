using System;
using Test1.Client;
using osu.Framework;
using osu.Framework.Platform;

namespace Test1
{
    class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"Test1"))
            using (osu.Framework.Game game = new GameClient())
            {
				
                host.Run(game);
            }
        }
    }
}
