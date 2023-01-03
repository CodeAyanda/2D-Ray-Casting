using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2D_Ray_Casting
{
    class Rays
    {
        public Point start;
        public Point end;
        public double angle;
        public int length = 5000;

        public Rays(Point p1, double anglee)
        {
            this.start = p1;
            this.angle = anglee;

            double endX = this.start.X + (length * Math.Cos(this.angle));
            double endY = this.start.Y + (length * Math.Sin(this.angle));

            this.end = new Point((int)endX, (int)endY);
        }

        public static Pen whitePen = new Pen(Color.White);

        public static void Draw(Graphics g)
        {
            for (double i = 0; i < 360; i += 1)
            {
                Rays currentRay = new Rays(new Point(Lightsource.x+9, Lightsource.y+9), i);
                foreach(Boundary wall in Boundary.walls)
                {
                    if (Intersect(currentRay, wall))
                    {
                        g.DrawLine(whitePen, currentRay.start, GetNewPoint(currentRay, wall));

                    }
                    else
                    {
                        g.DrawLine(whitePen, currentRay.start, currentRay.end);


                    }
                }
            }

        }

        public static bool Intersect(Rays ray, Boundary wall)
        {

            double x3 = ray.start.X;
            double y3 = ray.start.Y;
            double x4 = ray.end.X;
            double y4 = ray.end.Y;

            double x1 = wall.start.X;
            double y1 = wall.start.Y;
            double x2 = wall.end.X;
            double y2 = wall.end.Y;

            double den = ((x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4));
            double t;
            double u;


            if (den == 0)
            {
                t = -1;
            }
            else
            {
                t = ((x1 - x3) * (y3 - y4) - (y1 - y3) * (x3 - x4)) / den;

            }


            if (den == 0)
            {
                u = -1;
            }
            else
            {
                u = ((x1 - x3) * (y1 - y2) - (y1 - y3) * (x1 - x2)) / den;
            }

            if (t >= 0 && t <= 1 && u >= 0 && u <= 1)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public static Point GetNewPoint(Rays ray, Boundary wall)
        {
            double x1 = wall.start.X;
            double y1 = wall.start.Y;
            double x2 = wall.end.X;
            double y2 = wall.end.Y;

            double x3 = ray.start.X;
            double y3 = ray.start.Y;
            double x4 = ray.end.X;
            double y4 = ray.end.Y;


            double den = ((x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4));

            double t = ((x1 - x3) * (y3 - y4) - (y1 - y3) * (x3 - x4)) / den;

            double newX = (x1 + (t * (x2 - x1)));
            double newY = (y1 + (t * (y2 - y1)));


            return new Point((int)newX, (int)newY);
        }
    }
}
