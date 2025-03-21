using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Fireball : Projectile2d
    {
        public Fireball(Vector2 pos, Unit owner, Vector2 target) 
            : base("2d\\Projectiles\\Fireball", pos, new Vector2(20, 20), owner, target)
        {
            Done = false;
            Speed = 5;
            Owner = owner;

            Direction = target - Owner.Pos;
            Direction.Normalize();

            //1.2 second timer, how long the projectile lasts
            Timer = new McTimer(1200);
        }

        public override void Update(Vector2 offset, List<Unit> units)
        {
            base.Update(offset, units);
        }

        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }
    }
}
