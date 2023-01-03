using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_Ray_Casting
{
    public partial class Form1 : Form
    {
        public static Point mousePos;
        public Form1()
        {
            InitializeComponent();
            Boundary.CreateWalls();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            mousePos = this.PointToClient(Cursor.Position);

            Graphics g = e.Graphics;
            Lightsource.Draw(g);
            Boundary.Draw(g);
            Rays.Draw(g);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
