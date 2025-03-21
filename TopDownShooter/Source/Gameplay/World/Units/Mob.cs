using Microsoft.Xna.Framework;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World.Units
{
    public class Mob : Unit
    {
        public Mob(string path, Vector2 pos, Vector2 dims) : base(path, pos, dims) 
        {
            speed = 2;
        }

        public virtual void Update(Vector2 offset, Hero hero)
        {
            AI(hero);
            base.Update(offset);
        }

        public virtual void AI(Hero hero)
        {
            //Move towards the hero
            Pos += Globals.RadialMovement(hero.Pos, Pos, speed);

            //Rotate towards the hero
            Rot = Globals.RotateTowards(Pos, hero.Pos);
        }

        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }
    }
}
