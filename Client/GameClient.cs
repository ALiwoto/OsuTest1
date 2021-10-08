using System.IO;
using osu.Framework.Audio.Track;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Screens;
using osu.Framework;

namespace Test1.Client {
    public class GameClient : Game {
        private ScreenStack screenStack;

        [BackgroundDependencyLoader]
        private void load()
        {
            // Add your top-level game components here.
            // A screen stack and sample screen has been provided for convenience, but you can replace it if you don't want to use screens.
            Child = screenStack = new ScreenStack { RelativeSizeAxes = Axes.Both };
        }

        protected override void LoadComplete()
        {
            TrackBass b = new(File.OpenRead("/home/mrwoto/Music/01 - Kyoumen no Nami.mp3"));
            //TrackBass b = new(File.OpenRead("/home/mrwoto/Ali/Animes/Black/Black Clover - 165 [480p].mkv"));
            
            b.Failed += () => {
                System.Console.WriteLine("failed");
            };
            b.Completed += () => {
                System.Console.WriteLine("completed");
            };
            
            Audio.AddItem(b);
            
            screenStack.Push(new MainScreen());
            b.Start();
        }
        
    }
}