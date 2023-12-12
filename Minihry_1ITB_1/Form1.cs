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
    public partial class Form1 : Form
    {
        bool playersTurn = true;
        Random generator = new Random();

        public Form1() {
            InitializeComponent();
            player.Setup("Vrátík", false);
            pc.Setup("Android", true);
        }

        private void StartRound() {
            if(playersTurn) {
                // zapnutí minihry
                // získání finálního skóre
                // udělení poškození
                DealDamage(pc, 5);
            } else {
                int dmg = generator.Next(0,10);
                DealDamage(player, dmg);
            }
            SwitchPlayer();
        }

        private void SwitchPlayer() {
            playersTurn = !playersTurn;
        }

        private void DealDamage(PlayerOverview target, int dmg) {
            target.Hp -= dmg;
        }

        private void button1_Click(object sender, EventArgs e) {
            StartRound();
        }
    }
}
