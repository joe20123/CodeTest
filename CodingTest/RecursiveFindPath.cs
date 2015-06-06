using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    public class RecursiveFindPath
    {
        private class Point
        {
            
            public Point(int _x,int _y)
            {
                x=_x;
                y=_y;
            }
            public int x { get; set; }
            public int y { get; set; }
        }

        List<Point> currentPath = new List<Point>();
        public bool findpath(int x,int y)
        {
            Point p=new Point(x,y);
            currentPath.Add(p);
            if (x == 0 && y == 0) return true;
            bool success = false;
            //if (x >= 1 && is_free(x - 1, y))
            //{
            //    success = findpath(x - 1, y);
            //}
            //if (!success && y >= 1 && is_free(x, y - 1))
            //{
            //    success = findpath(x, y - 1);
            //}
            if (!success)
            {
                currentPath.Remove(p);
            }

            return success;
        }
    }
}
