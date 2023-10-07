using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MarpasEngine.Screen
{
    public class SceneManager
    {
        private Scene activeScene;
        public Scene ActiveScene
        {
            get { return activeScene; }
            set
            {
                activeScene.UnloadContent();
                activeScene = value;
                activeScene.Initialize();
                activeScene.LoadContent();
            }
        }

        public SceneManager(Scene activeScene)
        {
            this.activeScene = activeScene;
        }

        public void SwitchScene(Scene newScene)
        {
            activeScene.UnloadContent();
            activeScene = newScene;
            activeScene.Initialize();
            activeScene.LoadContent();
        }

        public void Update(GameTime gameTime)
        {
            activeScene.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            activeScene.Draw(spriteBatch);
        }
    }
}
