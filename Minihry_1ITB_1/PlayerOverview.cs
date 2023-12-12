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
    public partial class PlayerOverview : UserControl
    {
        private int hp = 100;

        public int Hp {
            get { return hp; }
            set {
                if (value > 100)
                    value = 100;

                if (value < 0)
                    value = 0;

                hp = value;
                progressBar1.Value = hp;
            }
        }

        public PlayerOverview() {
            InitializeComponent();
        }

        public void Setup(string name, bool isPc) {
            label1.Text = name;
            Hp = 100;

            if(isPc) {
                label1.TextAlign = ContentAlignment.MiddleRight;
                progressBar1.RightToLeft = RightToLeft.Yes;
                progressBar1.RightToLeftLayout = true;
            }
        }
    }
}
