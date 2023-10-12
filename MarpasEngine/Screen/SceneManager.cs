using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MarpasEngine.Screen
{
    public static class SceneManager
    {
        private static Scene activeScene;
        public static Scene ActiveScene
        {
            get { return activeScene; }
            set
            {
                if (activeScene is not null)
                    activeScene.UnloadContent();
                activeScene = value;
                activeScene.Initialize();
                activeScene.LoadContent();
            }
        }

        public static void SwitchScene(Scene newScene)
        {
            if (activeScene is not null)
            {
                activeScene.UnloadContent();
            }
            activeScene = newScene;
            activeScene.Initialize();
            activeScene.LoadContent();
        }

        public static void Update(GameTime gameTime)
        {
            if (activeScene is not null)
                activeScene.Update(gameTime);
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            if (activeScene is not null)
                activeScene.Draw(spriteBatch);
        }
    }
}
