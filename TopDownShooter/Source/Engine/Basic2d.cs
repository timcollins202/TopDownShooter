using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TopDownShooter.Source.Engine
{
    public class Basic2d
    {
        public float Rot;
        public Vector2 Pos;
        public Vector2 Dims;
        public Texture2D myModel;

        public Basic2d(string path, Vector2 pos, Vector2 dims)
        {
            Pos = pos;
            Dims = dims;

            myModel = Globals.content.Load<Texture2D>(path);
        }

        public virtual void Update()
        {

        }

        public virtual void Draw(Vector2 offset)
        {
            if (myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, 
                    new Rectangle((int)(Pos.X + offset.X), (int)(Pos.Y + offset.Y), (int)Dims.X, (int)Dims.Y),
                    null, 
                    Color.White,
                    Rot, 
                    new Vector2(myModel.Bounds.Width / 2, myModel.Bounds.Height / 2),
                    new SpriteEffects(),
                    0);
            }
        }

        public virtual void Draw( Vector2 offset, Vector2 origin)
        {
            if (myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, 
                    new Rectangle((int)(Pos.X + offset.X), (int)(Pos.Y + offset.Y), (int)Dims.X, (int)Dims.Y),
                    null, 
                    Color.White,
                    Rot, 
                    new Vector2(origin.X, origin.Y),
                    new SpriteEffects(), 
                    0);
            }
        }
    }
}
