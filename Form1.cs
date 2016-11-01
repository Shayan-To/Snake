using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            this.Main = new GameMain(this.gameMainControl1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gameMainControl1.Main = this.Main;
            this.Main.StartLife();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Main.EndLife();
        }

        private readonly GameMain Main;

    }
}
