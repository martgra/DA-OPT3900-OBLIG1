using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligEn
{
    public class RandomMethod
    {

        public static int[] randMethod(int[,] array, int cities)
        {
            Random rnd = new Random();
            int[] visited = Enumerable.Range(0, cities).OrderBy(x => rnd.Next()).Take(cities).ToArray();
            return visited;
        }
    }
}
