﻿namespace Minihry_1ITB_1
{
    partial class WtfForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pc = new Minihry_1ITB_1.PlayerOverview();
            this.player = new Minihry_1ITB_1.PlayerOverview();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(380, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 852);
            this.panel1.TabIndex = 2;
            // 
            // pc
            // 
            this.pc.Hp = 0;
            this.pc.Location = new System.Drawing.Point(1240, 12);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(362, 608);
            this.pc.TabIndex = 1;
            // 
            // player
            // 
            this.player.Hp = 0;
            this.player.Location = new System.Drawing.Point(12, 12);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(362, 608);
            this.player.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 780);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WtfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 963);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.player);
            this.Name = "WtfForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PlayerOverview player;
        private PlayerOverview pc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

