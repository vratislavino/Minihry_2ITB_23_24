using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minihry_1ITB_1
{
    public partial class Circle : Minigame
    {
        Pen circlePen = new Pen(Color.Red, 30);
        Pen successPen = new Pen(Color.Green, 30);
        Pen arrowPen = new Pen(Color.Magenta, 10);


        Timer timer;

        int circleSize;
        Random generator = new Random();

        int startDegree = 0;
        int successSize = 30;

        Point center;
        float currentAngle = 90;
        float speed = 2;
        float speedMultiplier = 1.1f;
        bool hasToHit = true;

        public Circle()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public override void StartMinigame()
        {
            circleSize = Width / 3 * 2;
            center = new Point(Width / 2, Height / 2);

            ReplaceSuccess();

            timer = new Timer();
            timer.Interval = 17;
            timer.Start();

            Paint += OnPaint;
            this.KeyDown += OnKeyDown;
            timer.Tick += OnTick;
        }

        private void ReplaceSuccess()
        {
            startDegree = generator.Next(210, 330);
        }

        private void OnTick(object sender, EventArgs e)
        {
            currentAngle += speed;
            if(currentAngle >= 360)
            {
                if(hasToHit)
                {
                    RaiseMinigameEnded();
                    timer.Stop();
                } else
                {
                    hasToHit = true;
                }
                currentAngle %= 360;


            }
            Refresh();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (currentAngle > startDegree && currentAngle < startDegree + successSize)
                {
                    ReplaceSuccess();
                    score++;
                    speed *= speedMultiplier;
                    successSize -= 2;
                    hasToHit = false;
                    if (score == 10)
                    {
                        RaiseMinigameEnded();
                        timer.Stop();
                    }
                } else
                {
                    RaiseMinigameEnded();
                    timer.Stop();
                }
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // vykreslení kolečka

            e.Graphics.DrawEllipse(circlePen, Width / 6, Height / 6, circleSize, circleSize);
            e.Graphics.DrawArc(successPen, Width / 6, Height / 6, circleSize, circleSize, -startDegree, -successSize);

            int x, y;
            double angleInRad = currentAngle / 180 * Math.PI;
            x = (int)(Math.Cos(angleInRad) * (circleSize / 2));
            y = -(int)(Math.Sin(angleInRad) * (circleSize / 2));

            e.Graphics.DrawLine(arrowPen, center.X, center.Y, center.X + x, center.Y + y);
        }
    }
}
