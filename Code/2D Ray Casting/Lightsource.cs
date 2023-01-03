using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _2D_Ray_Casting
{
    class Lightsource
    {
        public static int x;
        public static int y;
        public static int width = 18;

        public static System.Drawing.SolidBrush whiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);

        public static void Draw(Graphics g)
        {
            x = Form1.mousePos.X;
            y = Form1.mousePos.Y;

            Rectangle rect = new Rectangle(x, y, width, width);
            g.FillEllipse(whiteBrush, rect);

        }

    }
}
