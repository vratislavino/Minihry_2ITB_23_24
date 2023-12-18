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
    public partial class WtfForm : Form
    {
        List<Strike> strikes = new List<Strike>() { };
        bool playersTurn = true;
        Random generator = new Random();

        public WtfForm()
        {
            InitializeComponent();
            player.Setup("Vrátík", false);
            pc.Setup("Android", true);
        }

        private void StartRound()
        {
            if (playersTurn)
            {

                Minigame m = new Targets();
                m.MinigameEnded += (score) => {
                    DealDamage(pc, score);
                    panel1.Controls.Remove(m);
                    m.Dispose();
                    SwitchPlayer();
                };
                panel1.Controls.Add(m);
                m.StartMinigame();

            }
            else
            {
                int dmg = generator.Next(0, 10);
                DealDamage(player, dmg);
                SwitchPlayer();
            }
        }

        private void SwitchPlayer()
        {
            playersTurn = !playersTurn;
        }

        private void DealDamage(PlayerOverview target, int dmg)
        {
            target.Hp -= dmg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartRound();
        }
    }

    public class Strike
    {
        public string reason;
    }
}
