using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using TopDownShooter.Source.Engine;
using TopDownShooter.Source.Gameplay.World;
using TopDownShooter.Source.Gameplay.World.Units;

namespace TopDownShooter.Source
{
    public class World
    {
        public Vector2 offset;

        public Hero hero;
        public List<Projectile2d> projectiles;
        public List<Mob> mobs;
        public List<SpawnPoint> spawnPoints;

        public World()
        {
            GameGlobals.PassProjectile = AddProjectile;
            GameGlobals.PassMob = AddMob;

            hero = new Hero("2d\\Hero", new Vector2(300, 300), new Vector2(48, 48));
            projectiles = new List<Projectile2d>();
            mobs = new List<Mob>();
            spawnPoints = new List<SpawnPoint>();
            offset = new Vector2(0, 0);

            //Add spawnPoints, staggering the spawn times by a half second each time
            spawnPoints.Add(new SpawnPoint("2d\\Misc\\circle", new Vector2(50, 50), new Vector2(35, 35)));

            spawnPoints.Add(new SpawnPoint("2d\\Misc\\circle", new Vector2(Globals.screenWidth / 2, 50), new Vector2(35, 35)));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(500);

            spawnPoints.Add(new SpawnPoint("2d\\Misc\\circle", new Vector2(Globals.screenWidth - 50, 50), new Vector2(35, 35)));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(1000);

        }

        public virtual void Update()
        {
            hero.Update(offset);

            for (int i = 0; i < spawnPoints.Count; i++)
            {
                spawnPoints[i].Update(offset);

            }

            for (int i=0; i < projectiles.Count; i++)
            {
                projectiles[i].Update(offset, mobs.ToList<Unit>());

                if (projectiles[i].Done)
                {
                    projectiles.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < mobs.Count; i++)
            {
                mobs[i].Update(offset, hero);

                if (mobs[i].dead)
                {
                    mobs.RemoveAt(i);
                    i--;
                }
            }
        }

        public virtual void AddMob(object info)
        {
            mobs.Add((Mob)info);
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

            foreach (var spawnPoint in spawnPoints)
            {
                spawnPoint.Draw(offset);
            }

            foreach (var mob in mobs)
            {
                mob.Draw(offset);
            }
        }

    }
}
