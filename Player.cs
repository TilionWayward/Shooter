﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    class Player
    {
        // Animation represeting the Player
        public Texture2D PlayerTexture;

        // Position of the Player relative to the upper left side of the screen
        public Vector2 Position;

        // State of the Player
        public bool Active;

        // Amount of hit points that the Player has
        public int Health;

        // Get the width of the Player ship
        public int Width
        {
            get { return PlayerTexture.Width; }
        }

        // Get the height of the Player ship
        public int Height
        {
            get { return PlayerTexture.Height; }
        }

        public void Initialize(Texture2D texture, Vector2 position)
        {
            PlayerTexture = texture;

            //Set the starting position of the Player around the middle of the screen and to the back
            Position = position;

            // Set the Player to be active
            Active = true;

            // Set the Player health
            Health = 100;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
