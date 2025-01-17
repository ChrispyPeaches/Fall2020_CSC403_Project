﻿using System;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// This is the class for a coin
    /// </summary>
    public class Coin
    {
        public Vector2 Position { get; set; }
        public Collider Collider { get; set; }

        /// <summary>
        /// THis is the image for a coin
        /// </summary>
        public Image Img { get; set; }

        public int Amount { get; set; }
        public Guid ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="initPos">this is the initial position of the coin</param>
        /// <param name="collider">this is the collider for the coin</param>
        public Coin(Vector2 initPos, Collider collider, int amount = 1, Guid guid = new Guid())
        {
            Position = initPos;
            Collider = collider;
            Amount = amount;
            ID = guid;
        }
    }
}