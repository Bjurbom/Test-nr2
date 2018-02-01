using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestRe
{
    abstract class GameObject
    {
        protected Vector2 position, velocity;
        protected Texture2D texture;
        protected int layer;

        public GameObject(Vector2 position, Vector2 velocity, Texture2D texture, int layer)
        {
            this.position = position;
            this.velocity = velocity;
            this.texture = texture;
            this.layer = layer;
        }

        protected virtual Rectangle hitbox() // But what if it's a circle?
        {
            return new Rectangle();
        }

        public virtual void Update()
        {
            position += velocity;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

    }
}
