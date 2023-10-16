using Microsoft.Xna.Framework;
using System;

namespace MarpasEngine.Objects2D
{
    public struct Circle
    {
        public Vector2 Center = Vector2.Zero;
        public float Radius = 0f;

        public Circle(Vector2 center, float radius)
        {
            Center = center;
            Radius = radius;
        }

        public float Diameter => 2 * Radius;

        public float Circumference => 2 * MathF.PI * Radius;

        public float Area => MathF.PI * Radius * Radius;

        public bool Intersects(Circle other)
        {                  
            if (Vector2.Distance(Center, other.Center) < Radius + other.Radius)
            {
                return true;
            }
            return false;
        }

        public static float Distance(Circle circle1, Circle circle2)
        {
            return Vector2.Distance(circle1.Center, circle2.Center) - (circle1.Radius + circle2.Radius);
        }
    }
}
