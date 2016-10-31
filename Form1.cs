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
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gameMainControl1.Main = this.Main;
            this.Main.StartLife();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.gameMainControl1.ReportKeyDown(e.KeyCode);
        }

        private readonly GameMain Main = new GameMain();

    }
}
