using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minihry_1ITB_1
{
    public class Targets : Minigame
    {
        Timer updateTimer = new Timer();
        Random random = new Random();

        Target currentTarget;
        float speed = 0.1f;
        float levelSpeedMultiplier = 1.2f;

        public override void StartMinigame() {
            this.DoubleBuffered = true;
            updateTimer.Interval = 100;
            this.MouseDown += OnMouseDown;
            this.Paint += OnPaint;
            updateTimer.Tick += OnTick;
            GenerateTarget();
            updateTimer.Start();
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            currentTarget.Draw(e.Graphics);
        }

        private void GenerateTarget() {
            currentTarget = new Target(new Point(random.Next(0, Width), random.Next(0, Height)), 100f);
        }

        private void OnTick(object sender, EventArgs e) {
            currentTarget.size -= speed;
            if(currentTarget.size <= 0) {
                updateTimer.Stop();
                RaiseMinigameEnded();
            }
            
            Refresh();
        }

        private void OnMouseDown(object sender, MouseEventArgs e) {
            if(currentTarget.IsMouseIn(e.Location)) {
                score++;
                if(score > 10) {
                    updateTimer.Stop();
                    RaiseMinigameEnded();
                } else {
                    speed *= levelSpeedMultiplier;
                    GenerateTarget();
                }

            } else {
                updateTimer.Stop();
                RaiseMinigameEnded();
            }
        }

        class Target {

            public Point position;
            public float size;
            public SolidBrush color = new SolidBrush(Color.Red);

            public Target(Point position, float size) {
                this.position = position;
                this.size = size;
            }

            public void Draw(Graphics g) {
                g.FillEllipse(color, position.X - size / 2, position.Y - size / 2, size, size);
            }

            public bool IsMouseIn(Point mousePos) {
                double dist = Math.Sqrt(Math.Pow(mousePos.X - position.X, 2) + Math.Pow(mousePos.Y - position.Y, 2));
                return dist <= size / 2;
            }
        }
    }
}
