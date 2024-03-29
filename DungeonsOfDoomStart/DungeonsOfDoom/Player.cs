﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player : Character
    {
        public Player(int health, int x, int y) : base(health)
        {
          //  Health = health;
            X = x;
            Y = y;
            BackPack = new List<Item>();
        }

        //public int Health { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public List<Item> BackPack { get; set; }
    }
}
