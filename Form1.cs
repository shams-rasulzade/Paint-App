using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool draw;
        int x, y; //coordinate
        int thickness = 3;
        ColorDialog color = new ColorDialog();

        private void Form1_MouseDown(object sender, MouseEventArgs e) //when we click mouse buttons
        {
            draw = true;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) //when we move mouse 
        {
            Graphics graph = this.CreateGraphics();

            Pen pen = new Pen(color.Color, thickness);

            Point p1 = new Point(x, y);
            Point p2 = new Point(e.X, e.Y);

            if (draw == true)
            {
                graph.DrawLine(pen, p1, p2); // pen name, starting location, ending location
                x = e.X; // we define the last location as beginnign location
                y = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) //when we take off finger from mouse button
        {
            draw = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            color.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            thickness = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
