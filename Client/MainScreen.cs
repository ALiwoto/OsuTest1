
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;
using osu.Framework.Graphics.Video;
using osuTK.Graphics;

namespace Test1.Client
{
    public class MainScreen : Screen
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChildren = new Drawable[]
            {
				new Video("/home/mrwoto/Ali/Animes/Redo/Kaifuku Jutsushi - 8.mp4", true),
            };
			
        }
    }
}