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

        public override void StartMinigame() {
            updateTimer.Interval = 100;
            this.MouseDown += OnMouseDown;
            updateTimer.Tick += OnTick;
            GenerateTarget();
            updateTimer.Start();

            // Chybí mi tu paint :)
        }

        private void GenerateTarget() {
            currentTarget = new Target(new Point(random.Next(0, Width), random.Next(0, Height)), 100f);
        }

        private void OnTick(object sender, EventArgs e) {
            currentTarget.size -= 1;
            Refresh();
        }

        private void OnMouseDown(object sender, MouseEventArgs e) {
            // klikl na terč?
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
        }
    }
}
