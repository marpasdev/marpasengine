using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MarpasEngine.Objects2D
{
    public class AnimationManager
    {
        #region Properties
        public Dictionary<string, Animation> Anims;
        public Animation CurrentAnim;
        #endregion

        public AnimationManager()
        {
            Anims = new Dictionary<string, Animation>();
        }

        public AnimationManager(Dictionary<string, Animation> anims)
        {
            Anims = anims;
        }

        public void SwitchAnimation(string key)
        {
            if (Anims[key] is null)
                return;

            if (CurrentAnim is not null)
            {
                CurrentAnim.Stop();
                CurrentAnim.Reset();
            }

            CurrentAnim = Anims[key];
            CurrentAnim.Start();
        }

        public void Update(GameTime gameTime)
        {
            if (CurrentAnim is not null)
                CurrentAnim.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch, Sprite sprite)
        {
            if (CurrentAnim is not null)
                CurrentAnim.Draw(spriteBatch, sprite);
        }
    }
}
