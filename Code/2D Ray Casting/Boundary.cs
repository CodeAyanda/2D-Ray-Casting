using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2D_Ray_Casting
{
    class Boundary
    {
        public static int width = 1000;
        public static int height =  1000;
        public Point start;
        public Point end;
        static int numOfWalls = 1;
        public static Boundary[] walls = new Boundary[numOfWalls];

        public static Pen whitePen = new Pen(Color.Red, 3);

        public Boundary(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }


        public static void Draw(Graphics g)
        {
            foreach (Boundary currentWall in Boundary.walls)
            {
                g.DrawLine(whitePen, currentWall.start, currentWall.end);

            }
        }

        public static void CreateWalls()
        {
            Random rnd = new Random();
            for (int i = 0; i < numOfWalls; i++)
            {
                int x1 = rnd.Next(0, width);
                int y1 = rnd.Next(0, height);

                int x2 = rnd.Next(0, width);
                int y2 = rnd.Next(0, height);


                Boundary myWall = new Boundary(new Point(x1, y1), new Point(x2, y2));
                walls[i] = myWall;

            }
        }


    }
}
