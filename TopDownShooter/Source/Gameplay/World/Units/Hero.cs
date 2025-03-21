using Microsoft.Xna.Framework;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World.Units
{
    public class Hero : Unit
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
                Pos = new Vector2(Pos.X - speed, Pos.Y);
            }

            if (Globals.keyboard.GetPress("D"))
            {
                Pos = new Vector2(Pos.X + speed, Pos.Y);
            }

            if (Globals.keyboard.GetPress("W"))
            {
                Pos = new Vector2(Pos.X, Pos.Y - speed);
            }

            if (Globals.keyboard.GetPress("S"))
            {
                Pos = new Vector2(Pos.X, Pos.Y + speed);
            }

            //Rotate the hero towards the mouse cursor
            Rot = Globals.RotateTowards(Pos, new Vector2(Globals.mouse.newMouse.X, Globals.mouse.newMouse.Y));

            if (Globals.mouse.LeftClick())
            {
                GameGlobals.PassProjectile(new Fireball(new Vector2(Pos.X, Pos.Y), this, new Vector2(Globals.mouse.newMousePos.X, Globals.mouse.newMousePos.Y)));
            }

            base.Update();
        }

        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }
    }
}
