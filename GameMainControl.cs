using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class GameMainControl : Control
    {

        public GameMainControl()
        {
        }

        protected override bool IsInputKey(Keys keyData)
        {
            return true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Main?.Paint(e.Graphics);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            this.Main?.ReportKeyDown(e.KeyCode);
            base.OnKeyDown(e);
        }

        [System.ComponentModel.DefaultValue(null)]
        public GameMain Main
        {
            get;
            set;
        }

    }
}
