using Microsoft.Xna.Framework;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Hero : Basic2d
    {
        public Hero(string path, Vector2 pos, Vector2 dims) : base(path, pos, dims) 
        {
            
        }

        public override void Update()
        {
            if(Globals.keyboard.GetPress("A"))
            {
                _pos = new Vector2(_pos.X - 1, _pos.Y);
            }

            if (Globals.keyboard.GetPress("D"))
            {
                _pos = new Vector2(_pos.X + 1, _pos.Y);
            }

            if (Globals.keyboard.GetPress("W"))
            {
                _pos = new Vector2(_pos.X, _pos.Y - 1);
            }

            if (Globals.keyboard.GetPress("S"))
            {
                _pos = new Vector2(_pos.X, _pos.Y + 1);
            }

            base.Update();
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}
