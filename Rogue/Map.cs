using System;
using System.Collections.Generic;
using System.Text;

namespace Rogue
{
    public class Map
    {
        public int Level { get; set; }
        public List<List<char>> Chart { get; set; }

        public Map (int Level, int x = 20, int y = 20)
        {

        }
    }
}
