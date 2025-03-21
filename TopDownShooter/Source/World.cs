using Microsoft.Xna.Framework;
using System.Collections.Generic;
using TopDownShooter.Source.Gameplay.World;
using TopDownShooter.Source.Gameplay.World.Units;

namespace TopDownShooter.Source
{
    public class World
    {
        public Hero hero;
        public List<Projectile2d> projectiles;
        public Vector2 offset;

        public World()
        {
            hero = new Hero("2d\\Hero", new Vector2(300, 300), new Vector2(48, 48));
            projectiles = new List<Projectile2d>();
            offset = new Vector2(0, 0);

            GameGlobals.PassProjectile = AddProjectile;
        }

        public virtual void Update()
        {
            hero.Update();

           for (int i=0; i < projectiles.Count; i++)
            {
                projectiles[i].Update(offset, null);

                if (projectiles[i].Done)
                {
                    projectiles.RemoveAt(i);
                    i--;
                }
            }
        }

        public virtual void AddProjectile(object info)
        {
            projectiles.Add((Projectile2d)info);
        }

        public virtual void Draw(Vector2 offset)
        {
            hero.Draw(offset);

            foreach (var projectile in projectiles)
            {
                projectile.Draw(offset);
            }
        }

    }
}
