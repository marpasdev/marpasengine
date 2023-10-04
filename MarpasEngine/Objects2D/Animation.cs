using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MarpasEngine.Objects2D
{
    public class Animation
    {
        #region Properties
        private readonly Texture2D texture;
        private readonly List<Rectangle> sourceRectangles = new();
        private readonly int frames;
        private int frame;
        private readonly float frameTime;
        private float frameTimeLeft;
        private bool active = true;
        #endregion

        public Animation(Texture2D texture, int framesX, float frameTime)
        {
            this.texture = texture;
            this.frameTime = frameTime;
            frameTimeLeft = this.frameTime;
            frames = framesX;
            var frameWidth = texture.Width / framesX;
            var frameHeight = texture.Height;

            for (int i = 0; i < frames; i++)
            {
                sourceRectangles.Add(new(i * frameWidth, 0, frameWidth, frameHeight));
            }
        }

        #region Manipulation Methods
        public void Stop()
        {
            active = false;
        }

        public void Start()
        {
            active = true;
        }

        public void Reset()
        {
            frame = 0;
            frameTimeLeft = frameTime;
        }
        #endregion

        public void Update(GameTime gameTime)
        {
            if (!active)
            {
                return;
            }

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            frameTimeLeft -= deltaTime;

            if (frameTimeLeft <= 0)
            {
                frameTimeLeft = frameTime;
                frame = (frame + 1) % frames;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Sprite sprite)
        {
            spriteBatch.Draw(texture, sprite.Position, sourceRectangles[frame], sprite.Color, sprite.Rotation, sprite.Origin, sprite.Scale, sprite.SpriteEffects, sprite.LayerDepth);
        }
    }
}
