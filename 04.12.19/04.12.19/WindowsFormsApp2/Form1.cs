using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<double> kusrValue;
        int margins = 60;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            kusrValue = new List<double>() { 27.80, 27.40, 26.80, 26.50, 26.30, 26.60, 25.90, 25.80, 25.70, 25.00, 24.10, 24.00 };
            this.MinimumSize = new Size(margins * 5, margins * 5); // отступы
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Image im = Image.FromFile("grid.png");
            Bitmap bmp = new Bitmap(im, new Size(830, 470));
           g = Graphics.FromImage(bmp);


            pictureBox1.Image=bmp;

            Pen graf = new Pen(Color.Black, 4.5f);
            graf.EndCap = LineCap.ArrowAnchor;
            //
            Point pointStat = new Point(margins, pictureBox1.ClientSize.Height - margins);
            
            // ось Y
            g.DrawLine(graf,
                new Point(pointStat.X, pointStat.Y + margins / 4),
                new Point(pointStat.X, margins));

            // ось X
            g.DrawLine(graf,
                new Point(pointStat.X - margins / 4, pointStat.Y),
                new Point(pictureBox1.ClientSize.Width-margins, pointStat.Y));

            int width = this.ClientSize.Width - margins*2;
            int height = this.ClientSize.Height - margins* 3;
            int raznost = width / kusrValue.Count;

            double maxValue = Math.Ceiling(kusrValue.Max());
            double minValue = Math.Floor(kusrValue.Min());

            int ValueLine = height / 6;
            double pxUnit = (height - ValueLine) / (maxValue - minValue);

            Pen lineKusr = new Pen(Color.Blue, 1.0f);

            lineKusr.DashStyle = DashStyle.Dash;

            List<PointF> tempPoints = new List<PointF>();

            for (int i = 0; i < kusrValue.Count; i++)
            {
                PointF p = new PointF(pointStat.X + i * raznost, (float)(pointStat.Y - ValueLine - (kusrValue[i] - minValue)*pxUnit));

                g.DrawLine(
                    lineKusr,
                    new PointF(p.X, pointStat.Y),
                    new PointF(p.X, p.Y));

                //цифры

                if (kusrValue[i] == maxValue || kusrValue[i] == minValue)
                {
                    g.DrawLine(
                        Pens.Black,
                        new PointF(pointStat.X - 5, p.Y),
                        new PointF(pointStat.X + 5, p.Y));

                    SizeF dig1 = g.MeasureString(kusrValue[i].ToString(), this.Font);

                    g.DrawString(kusrValue[i].ToString(), this.Font, Brushes.Black,
                    new PointF(pointStat.X - dig1.Width - 5, p.Y - dig1.Height / 2));
                }
               
                tempPoints.Add(p);
            }

            for (int i = (int)minValue; i <= maxValue; i++)
            {
                PointF p2= new PointF(pointStat.X + i * raznost, (float)(pointStat.Y - ValueLine - (i - minValue) * pxUnit));
                //g.DrawLine(
                //   lineKusr,
                //   p2,
                //    new PointF(width, (float)(pointStat.Y - ValueLine - (i - minValue) * pxUnit)));
                var dig2 = g.MeasureString(i.ToString(), this.Font);
                g.DrawString(i.ToString(), this.Font, Brushes.Black,
                p2.X - dig2.Width - 3, p2.Y - dig2.Height / 2);           
            }
            Pen chPen = new Pen(Color.Red, 2);
            g.DrawLines(chPen, tempPoints.ToArray());

            //grid
            //for (int x = 0; x <= 11; x++)
            //{
            //    for (int y = 0; y <= kusrValue[kusrValue.Count - 1]; y++)
            //    {
            //        g.DrawRectangle(Pens.Black, dx * x + 10, y * dy + 10, dx, dy);
            //    }
            //}



           g.Dispose();
           
        }

        private void Form1_Resize(object sender, EventArgs e)
        { 
            //знячения default
            g.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            this.Invalidate();
        }
    }
}
