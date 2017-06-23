using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TileIconifier.Controls.IconifierPanel.PictureBox;

namespace TileIconifier.Forms.Main
{
    public partial class Form1 : TileIconifier.Forms.SkinnableForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public PannablePictureBox pnbox;

        private void button3_Click(object sender, EventArgs e)
        {
            pnbox.OutputSize = new Size(200, 200);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnbox.OutputSize = new Size(100, 100);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pnbox.AutoSize = true;
            pnbox.AutoSize = false;
            pnbox.AutoSize = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ////panel2.Controls.Clear();
            panel2.Controls.Add(pnbox);
        }
    }
}
