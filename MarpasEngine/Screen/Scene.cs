using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MarpasEngine.Screen
{
    public abstract class Scene
    {
        protected Game game;
        protected GraphicsDeviceManager graphics;
        protected ContentManager content;

        public Scene(Game game, GraphicsDeviceManager graphics)
        {
            if (game is null)
            {
                throw new ArgumentNullException(nameof(game), "Game cannot be null.");
            }

            this.game = game;
            this.graphics = graphics;
        }

        public virtual void Initialize()
        {
            content = new ContentManager(game.Services);
            content.RootDirectory = game.Content.RootDirectory;
        }

        public virtual void LoadContent() { }

        public virtual void UnloadContent()
        {
            content.Unload();
            content = null;
        }

        public virtual void Update(GameTime gameTime) { }

        public virtual void Draw(SpriteBatch spriteBatch) { }

    }
}
