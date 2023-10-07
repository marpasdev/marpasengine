using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarpasEngine.Screen
{
    public abstract class Scene
    {
        protected Game game;
        protected ContentManager content;

        public Scene(Game game)
        {
            if (game is null)
            {
                throw new ArgumentNullException(nameof(game), "Game cannot be null.");
            }

            this.game = game;
        }

        public virtual void Initialize()
        {
            content = new ContentManager(game.Services);
            content.RootDirectory = game.Content.RootDirectory;
            LoadContent();
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
