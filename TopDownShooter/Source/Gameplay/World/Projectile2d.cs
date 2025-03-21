using Microsoft.Xna.Framework;
using System.Collections.Generic;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Projectile2d : Basic2d
    {
        public bool Done;
        public float Speed;

        public Vector2 Direction;
        public Unit Owner;
        public McTimer Timer;

        public Projectile2d(string path, Vector2 pos, Vector2 dims, Unit owner, Vector2 target) : base(path, pos, dims)
        {
            Done = false;
            Speed = 5;
            Owner = owner;

            Direction = target - Owner.Pos;
            Direction.Normalize();

            Rot = Globals.RotateTowards(pos, new Vector2(target.X, target.Y));

            //1.2 second timer, how long the projectile lasts
            Timer = new McTimer(1200);
        }

        public virtual void Update(Vector2 offset, List<Unit> units)
        {
            Pos += Direction * Speed;
            Timer.UpdateTimer();

            //set Done to true if timer has passed
            if (Timer.Test())
            {
                Done = true;
            }

            if (HitSomething(units))
            {               
                Done = true;
            }
        }

        public virtual bool HitSomething(List<Unit> units)
        {
            for (int i = 0; i < units.Count; i++)
            {
                if (Globals.GetDistance(Pos, units[i].Pos) < units[i].hitDist)
                {
                    units[i].GetHit();
                    return true;
                }
            }


            return false;
        }

        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }
    }
}
