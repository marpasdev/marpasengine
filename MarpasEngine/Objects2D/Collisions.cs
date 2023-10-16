using Microsoft.Xna.Framework;

namespace MarpasEngine.Objects2D
{
    public static class Collisions
    {

        public static bool CheckAABB(Rectangle obj1, Rectangle obj2)
        {
            if (obj1.Intersects(obj2))
            {
                return true;
            }
            return false;
        }

        public static bool CheckCircle(Circle obj1, Circle obj2)
        {
            if (obj1.Intersects(obj2))
            {
                return true;
            }
            return false;
        }
    }
}
