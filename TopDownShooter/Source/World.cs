using Microsoft.Xna.Framework;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source
{
    public class World
    {
        public Basic2d Hero;

        public World()
        {
            Hero = new Basic2d("2d\\Hero", new Vector2(300, 300), new Vector2(48, 48));
        }

        public virtual void Update()
        {
            Hero.Update();
        }

        public virtual void Draw()
        {
            Hero.Draw();
        }

    }
}
