using Microsoft.Xna.Framework;
using TopDownShooter.Source.Engine;
using TopDownShooter.Source.Gameplay.World;

namespace TopDownShooter.Source
{
    public class World
    {
        public Hero hero;

        public World()
        {
            hero = new Hero("2d\\Hero", new Vector2(300, 300), new Vector2(48, 48));
        }

        public virtual void Update()
        {
            hero.Update();
        }

        public virtual void Draw()
        {
            hero.Draw();
        }

    }
}
