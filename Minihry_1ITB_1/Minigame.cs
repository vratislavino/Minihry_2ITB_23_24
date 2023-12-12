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
    public partial class Minigame : UserControl
    {
        public event Action<int> MinigameEnded;

        protected int score;

        public Minigame() {
            InitializeComponent();
        }

        public virtual void StartMinigame() { }

        protected void RaiseMinigameEnded() {
            MinigameEnded?.Invoke(score);
        }
    }
}
