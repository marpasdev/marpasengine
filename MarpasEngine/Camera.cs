using Microsoft.Xna.Framework;

namespace MarpasEngine
{
    public static class Camera
    {
        public static Matrix Translation = Matrix.Identity;

        public static void UpdateTranslation(Vector2 position, GraphicsDeviceManager graphics)
        {
            float x = (graphics.PreferredBackBufferWidth / 2) - position.X;
            float y = (graphics.PreferredBackBufferHeight / 2) - position.Y;

            Translation = Matrix.CreateTranslation(x, y, 0f);
        }
    }
}
