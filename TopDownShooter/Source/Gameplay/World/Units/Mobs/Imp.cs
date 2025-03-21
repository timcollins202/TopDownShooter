using Microsoft.Xna.Framework;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World.Units
{
    public class Imp : Mob
    {
        public Imp(Vector2 pos) 
            : base("2d\\Units\\Mobs\\Imp", pos, new Vector2(40,40)) 
        {
            speed = 2;
        }

        public override void Update(Vector2 offset, Hero hero)
        {
            AI(hero);
            base.Update(offset, hero);
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
