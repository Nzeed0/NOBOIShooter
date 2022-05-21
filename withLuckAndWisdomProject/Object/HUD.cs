﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using withLuckAndWisdomProject.Screens;


// HUD contains the score value and distance value. 
namespace withLuckAndWisdomProject.Object
{
    public class HUD
    {
        private int _score;
        private int _distance;
        private SpriteFont _font;

        public HUD()
        {
            // Font Init.
            _font = ResourceManager.font;
        }

        public void DrawScore(SpriteBatch spriteBatch)
        {
            // Draw Score Section.

            // Score = Distance * 0.2; 
            
        }

        public void DrawDistance(SpriteBatch spriteBatch)
        {
            // Draw Distance Section.

            // Reference from Rabbit X Position.

        }

        public void update(GameTime gameTime)
        {

        }

        public void draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //spriteBatch.Begin();
            spriteBatch.DrawString(_font, "Score", new Vector2(100, 20), Color.Black);
            spriteBatch.DrawString(_font, "Distance", new Vector2(700, 20), Color.Black);
            //spriteBatch.End(); 
        }
    }
}
