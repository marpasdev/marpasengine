using Microsoft.Xna.Framework;
using System;

namespace MarpasEngine.Objects2D
{
    public struct Circle
    {
        public Vector2 Position = Vector2.Zero;
        public float Radius = 0f;

        public Circle(Vector2 position, float radius)
        {
            Position = position;
            Radius = radius;
        }

        public float Diameter => 2 * Radius;

        public float Circumference => 2 * MathF.PI * Radius;

        public float Area => MathF.PI * Radius * Radius;

        public bool Intersects(Circle other)
        {
            if (Vector2.DistanceSquared(Position, other.Position) < (Radius * Radius) + (other.Radius * other.Radius))
            {
                return true;
            }
            return false;
        }
    }
}
