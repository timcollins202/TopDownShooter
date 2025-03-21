using Microsoft.Xna.Framework;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Hero : Basic2d
    {
        public float speed;

        public Hero(string path, Vector2 pos, Vector2 dims) : base(path, pos, dims) 
        {
            speed = 2;
        }

        public override void Update()
        {
            if(Globals.keyboard.GetPress("A"))
            {
                _pos = new Vector2(_pos.X - speed, _pos.Y);
            }

            if (Globals.keyboard.GetPress("D"))
            {
                _pos = new Vector2(_pos.X + speed, _pos.Y);
            }

            if (Globals.keyboard.GetPress("W"))
            {
                _pos = new Vector2(_pos.X, _pos.Y - speed);
            }

            if (Globals.keyboard.GetPress("S"))
            {
                _pos = new Vector2(_pos.X, _pos.Y + speed);
            }

            //Rotate the hero towards the mouse cursor
            _rot = Globals.RotateTowards(_pos, new Vector2(Globals.mouse.newMouse.X, Globals.mouse.newMouse.Y));

            base.Update();
        }

        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }
    }
}
