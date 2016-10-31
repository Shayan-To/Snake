using System;
using System.Collections.Generic;
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

        internal void ReportKeyDown(Keys key)
        {
            this.Main.ReportKeyDown(key);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            this.Main.ReportKeyDown(e.KeyCode);
            base.OnKeyDown(e);
        }

        public override bool Focused
        {
            get
            {
                return true;
            }
        }

        private GameMain _Main;

        [System.ComponentModel.DefaultValue(null)]
        public GameMain Main
        {
            get
            {
                return this._Main;
            }
            set
            {
                this._Main = value;
                this.Main.Graphics = this.CreateGraphics();
            }
        }

    }
}
