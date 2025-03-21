using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TopDownShooter.Source;
using TopDownShooter.Source.Engine;
using TopDownShooter.Source.Engine.Input;

namespace TopDownShooter
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;

        World _world;

        Basic2d _cursor;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.content = this.Content;
            Globals.spriteBatch = new SpriteBatch(GraphicsDevice);

            _cursor = new Basic2d("2d\\Misc\\CursorArrow", new Vector2(0,0), new Vector2(28, 28));

            Globals.keyboard = new McKeyboard();
            Globals.mouse = new McMouseControl();

            _world = new World();

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            Globals.keyboard.Update();
            Globals.mouse.Update();

            _world.Update();

            Globals.keyboard.UpdateOld();
            Globals.mouse.UpdateOld();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            //Open the spriteBatch
            Globals.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);

            _world.Draw(Vector2.Zero);
            _cursor.Draw(new Vector2(Globals.mouse.newMousePos.X, Globals.mouse.newMousePos.Y), new Vector2(0, 0));

            //close the spriteBatch
            Globals.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
