
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class UI
    {
        public SpriteFont font;

        public UI()
        {
            font = Globals.content.Load<SpriteFont>("Fonts\\Arial16");
        }

        public void Update(Source.World world)
        {

        }

        public void Draw(Source.World world)
        {
            string tempStr = "Num Killed = " + world.numKilled;
            Vector2 strDims = font.MeasureString(tempStr);
            Globals.spriteBatch.DrawString(
                font, 
                tempStr, 
                new Vector2(Globals.screenWidth / 2 - strDims.X / 2, Globals.screenHeight - 40), 
                Color.Black);
        }
    }
}
