using Microsoft.Xna.Framework;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Unit : Basic2d
    {
        public float speed;

        public Unit(string path, Vector2 pos, Vector2 dims) : base(path, pos, dims)
        {
            speed = 2;
        }

        public override void Update()
        {
            
            base.Update();
        }

        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }
    }
}
