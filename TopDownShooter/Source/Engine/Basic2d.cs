using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TopDownShooter.Source.Engine
{
    public class Basic2d
    {
        public float _rot;
        public Vector2 _pos;
        public Vector2 _dims;
        public Texture2D myModel;

        public Basic2d(string path, Vector2 pos, Vector2 dims)
        {
            _pos = pos;
            _dims = dims;

            myModel = Globals.content.Load<Texture2D>(path);
        }

        public virtual void Update()
        {

        }

        public virtual void Draw(Vector2 offset)
        {
            if (myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, new Rectangle((int)(_pos.X + offset.X), (int)(_pos.Y + offset.Y), (int)_dims.X, (int)_dims.Y),
                    null, Color.White, _rot, new Vector2(myModel.Bounds.Width / 2, myModel.Bounds.Height / 2),
                    new SpriteEffects(), 0);
            }
        }

        public virtual void Draw( Vector2 offset, Vector2 origin)
        {
            if (myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, new Rectangle((int)(_pos.X + offset.X), (int)(_pos.Y + offset.Y), (int)_dims.X, (int)_dims.Y),
                    null, Color.White, _rot, new Vector2(origin.X, origin.Y),
                    new SpriteEffects(), 0);
            }
        }
    }
}
