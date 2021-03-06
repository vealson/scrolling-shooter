﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ScrollingShooter
{
    /// <summary>
    /// A basic bullet 
    /// </summary>
    public class Bullet : Projectile
    {
        /// <summary>
        /// Creates a new bullet
        /// </summary>
        /// <param name="content">A ContentManager to load content from</param>
        /// <param name="position">A position on the screen</param>
        public Bullet(ContentManager content, Vector2 position)
        {   
            this.spriteSheet = content.Load<Texture2D>("Spritesheets/tyrian.shp.01D8A7");

            this.spriteBounds = new Rectangle(38, 57, 7, 11);

            this.velocity = new Vector2(0, -300);

            this.position = position;
        }
    }
}
