using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rogue
{
    public class Map
    {
        public int Level { get; set; }
        public List<List<char>> Chart { get; set; }

        public Map (int level, int x = 40, int y = 20)
        {
            Level = level;
            var map = new List<List<char>>();
            for(int i = 0; i < y; i++)
            {
                var arr = new string('.', x).ToCharArray();
                var line = arr.ToList();
                map.Add(line);
            }
            Chart = map;
        }
        
        public void PrintMap()
        {
            for (int i = 0; i < Chart.Count; i++)
                Console.WriteLine(string.Join("",Chart[i]));
        }

    }
}
