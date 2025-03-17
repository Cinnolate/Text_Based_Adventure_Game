using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Rooms
    {
        public int north, west, east, south;

        public string name;
        public string desc;

        public Rooms (int n, int w, int e, int s)
        {
            north = n;
            west = w;
            east = e;
            south = s;
        }

        public override string ToString()
        {
            return ("You are currently in the " + name + "\n" + desc);
        }
    }
}
