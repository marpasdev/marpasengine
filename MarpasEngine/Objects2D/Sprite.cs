﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MarpasEngine.Objects2D
{
    public class Sprite
    {
        #region Properties
        public Texture2D Texture { get; set }
        public Vector2 Position { get; set }
        public Color Color { get; set } = Color.White;
        public float Rotation { get; set } = 0f;
        public Vector2 Origin { get; set } = Vector2.Zero;
        public Vector2 Scale { get; set } = Vector2.One;
        public SpriteEffects SpriteEffects { get; set } = SpriteEffects.None;
        public float LayerDepth { get; set } = 1f;
        #endregion

        public Sprite(Texture2D texture)
        {
            Texture = texture;
        }

        public Sprite(Texture2D texture, Vector2 position)
        {
            Texture = texture;
            Position = position;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color, Rotation, Origin, Scale, SpriteEffects, LayerDepth);
        }

        public Rectangle Rectangle => new Rectangle((int)Position.X, (int)Position.Y, Texture.Width * (int)Scale.X, Texture.Height * (int)Scale.Y);

        public Vector2 Center()
        {
            Vector2 originalCenter = new Vector2(Texture.Width / 2f, Texture.Height / 2f);

            Matrix transformMatrix = Matrix.CreateScale(Scale.X, Scale.Y, 0f) * Matrix.CreateRotationZ(Rotation) * Matrix.CreateTranslation(Position.X, Position.Y, 0f);

            Vector2 center = Vector2.Transform(originalCenter, transformMatrix);

            return center;
        }

        public void LookAt(Vector2 position)
        {
            Vector2 deltaPosition = Position - position;

            Rotation = (float)Math.Atan2(deltaPosition.Y, deltaPosition.X);
        }
    }
}
