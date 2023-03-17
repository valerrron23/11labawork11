using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11labawork11
{
    public partial class Form1 : Form
    {
        SolidBrush zemlya = new SolidBrush(Color.DarkSeaGreen);
        SolidBrush stolb = new SolidBrush(Color.Sienna);
        SolidBrush elka1 = new SolidBrush(Color.SeaGreen);
        SolidBrush elka2 = new SolidBrush(Color.SeaGreen);
        SolidBrush elka3 = new SolidBrush(Color.SeaGreen);
        SolidBrush elka4 = new SolidBrush(Color.SeaGreen);
        SolidBrush elka5 = new SolidBrush(Color.SeaGreen);
        SolidBrush dom1 = new SolidBrush(Color.Orchid);
        SolidBrush dom2 = new SolidBrush(Color.DeepPink);
        SolidBrush kriha1 = new SolidBrush(Color.SlateBlue);
        SolidBrush kriha2 = new SolidBrush(Color.DarkViolet);
        SolidBrush dver = new SolidBrush(Color.Indigo);
        SolidBrush okno1 = new SolidBrush(Color.Pink);
        SolidBrush okno2 = new SolidBrush(Color.Pink);
        SolidBrush tryba = new SolidBrush(Color.SlateBlue);
        SolidBrush kust1 = new SolidBrush(Color.MediumSeaGreen);
        SolidBrush kust2 = new SolidBrush(Color.MediumSeaGreen);
        SolidBrush kust3 = new SolidBrush(Color.MediumSeaGreen);
        SolidBrush kust4 = new SolidBrush(Color.MediumSeaGreen);
        SolidBrush kust5 = new SolidBrush(Color.MediumSeaGreen);
        SolidBrush kust6 = new SolidBrush(Color.MediumSeaGreen);
        SolidBrush solnce = new SolidBrush(Color.Gold);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // небо
            Graphics g = e.Graphics;
            g.Clear(Color.LightSkyBlue);
            // земля
            g.FillRectangle(zemlya, 0, 375, 2000, 1000);

            Point point1 = new Point(250, 195);
            Point point2 = new Point(550, 195);
            Point point4 = new Point(300, 265);
            Point point3 = new Point(495, 265);
            Point[] stolbPoints =
            {
              point1,
              point2,
              point3,
              point4,
            };
            g.FillRectangle(stolb, 110, 179, 30, 200);

            Point point5 = new Point(14, 223);
            Point point6 = new Point(125, 129);
            Point point7 = new Point(227, 222);
            Point[] elka1Points =
            {
            point5,
            point6,
            point7,
            };
            g.FillPolygon(elka1, elka1Points);

            Point point8 = new Point(47, 129);
            Point point9 = new Point(123, 43);
            Point point10 = new Point(205, 129);
            Point[] elka2Points =
            {
            point8,
            point9,
            point10,
            };
            g.FillPolygon(elka2, elka2Points);

            Point point11 = new Point(71, 45);
            Point point12 = new Point(180, 45);
            Point point13 = new Point(124, 4);
            Point[] elka3Points =
            {
            point11,
            point12,
            point13,
            };
            g.FillPolygon(elka3, elka3Points);


            Point point14 = new Point(14, 341);
            Point point15 = new Point(227, 341);
            Point point16 = new Point(123, 223);
            Point[] elka4Points =
            {
            point14,
            point15,
            point16,
            };
            g.FillPolygon(elka4, elka4Points);

            Point point17 = new Point(14, 341);
            Point point18 = new Point(227, 341);
            Point point19 = new Point(123, 223);
            Point[] elka5Points =
            {
            point17,
            point18,
            point19,
            };
            g.FillPolygon(elka5, elka5Points);


            g.FillRectangle(dom1, 330, 320, 280, 200);

            g.FillRectangle(dom2, 600, 320, 240, 200);

            Point point20 = new Point(278, 321);
            Point point21 = new Point(469, 131);
            Point point22 = new Point(660, 321);
            Point[] kriha1Points =
            {
            point20,
            point21,
            point22,
            };
            g.FillPolygon(kriha1, kriha1Points);

            Point point23 = new Point(900, 321);
            Point point24 = new Point(700, 131);
            Point[] kriha2Points =
            {
            point21,
            point22,
            point23,
            point24,
            };
            g.FillPolygon(kriha2, kriha2Points);


            g.FillRectangle(dver, 385, 380, 80, 140);

            g.FillRectangle(okno1, 498, 380, 92, 70);

            g.FillRectangle(okno2, 438, 190, 60, 50);

            g.FillRectangle(tryba, 520, 140, 60, 120);

            g.FillEllipse(kust1, 50, 410, 160, 100);

            g.FillEllipse(kust2, 10, 450, 130, 100);

            g.FillEllipse(kust3, 110, 450, 130, 100);

            g.FillEllipse(kust4, 480, 580, 160, 100);

            g.FillEllipse(kust5, 520, 540, 130, 100);

            g.FillEllipse(kust6, 570, 580, 130, 100);

            g.FillEllipse(solnce, 720, 10, 80, 80);
        }
    }
}
