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
    class Player
    {
        Vector2 position, velocity;
        Texture2D texture;
        public Player(Vector2 position, Vector2 velocity, Texture2D texture)
        {
            this.position = position;
            this.velocity = velocity;
            this.texture = texture;
        }

        public void Update()
        {
            position += velocity;
        }


    }
}
