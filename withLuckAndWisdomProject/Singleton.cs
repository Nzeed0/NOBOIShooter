﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace withLuckAndWisdomProject
{
    //apply for singleton design pattern
    class Singleton
    {
        public bool IsMouseVisible = true;
        public string ContentRootDir = "Content";
        public readonly int ScreenHeight = 720;
        public readonly int ScreenWidth = 1280;

        //Base of singleton
        private static Singleton s_instance;

        //Constructor
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new Singleton();
                }
                return s_instance;
            }
        }
    }
}