using Microsoft.Xna.Framework;
using TopDownShooter.Source.Engine;
using TopDownShooter.Source.Gameplay.World.Units;

namespace TopDownShooter.Source.Gameplay.World
{
    public class SpawnPoint : Basic2d
    {
        public bool dead;
        public float hitDist;

        public McTimer spawnTimer;

        public SpawnPoint(string path, Vector2 pos, Vector2 dims) : base(path, pos, dims)
        {
            dead = false;
            hitDist = 35;

            spawnTimer = new McTimer(2200);
        }

        public override void Update(Vector2 offset)
        {
            spawnTimer.UpdateTimer();

            if (spawnTimer.Test())
            {
                SpawnMob();
                spawnTimer.ResetToZero();
            }

            base.Update(offset);
        }

        public virtual void GetHit()
        {
            dead = true;
        }

        public virtual void SpawnMob()
        {
            GameGlobals.PassMob(new Imp(new Vector2(Pos.X, Pos.Y)));
        }

        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }
    }
}
