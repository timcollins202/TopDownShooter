using Microsoft.Xna.Framework;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Unit : Basic2d
    {
        public bool dead;
        public float speed;
        public float hitDist;

        public Unit(string path, Vector2 pos, Vector2 dims) : base(path, pos, dims)
        {
            dead = false;
            speed = 2;
            hitDist = 35;
        }

        public override void Update(Vector2 offset)
        {            
            base.Update(offset);
        }

        public virtual void GetHit()
        {
            dead = true;
        }

        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }
    }
}
