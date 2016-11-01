using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class GameMain
    {

        public GameMain()
        {
            var t = new Point(0, 0);
            for (int i = 0; i < InitialLength; i++)
            {
                this.Points.Enqueue(t);
                t += this.Direction;
            }
        }

        internal void ReportKeyDown(Keys key)
        {
            Size dir;
            switch (key)
            {
                case Keys.Up:
                    dir = new Size(0, -1);
                    break;
                case Keys.Down:
                    dir = new Size(0, 1);
                    break;
                case Keys.Left:
                    dir = new Size(-1, 0);
                    break;
                case Keys.Right:
                    dir = new Size(1, 0);
                    break;
                default:
                    return;
            }

            var LastDirection = this.Direction;
            if (this.DirectionQueue.Count != 0)
            {
                LastDirection = this.DirectionQueue.Last();
            }
            if ((dir.Width == 0) == (LastDirection.Width == 0))
            {
                return;
            }

            if (this.DirectionQueue.Count > 1)
            {
                var t = this.DirectionQueue.Peek();
                this.DirectionQueue.Clear();
                this.DirectionQueue.Enqueue(t);
            }
            this.DirectionQueue.Enqueue(dir);
        }

        public async void StartLife()
        {
            this.IsLiving = true;
            while (true)
            {
                await Task.Delay(DelayInterval);

                if (!this.IsLiving)
                {
                    break;
                }

                if (this.DirectionQueue.Count != 0)
                {
                    this.Direction = this.DirectionQueue.Dequeue();
                }
                this.Points.Enqueue(this.Points.Last() + this.Direction);
                this.Points.Dequeue();
                this.Repaint();
            }
        }

        public void EndLife()
        {
            this.IsLiving = false;
        }

        public void Repaint()
        {
            this.Graphics.Clear(Color.White);
            foreach (var e in this.Points)
            {
                this.Graphics.FillRectangle(Brushes.Black, e.X * BlockSize, e.Y * BlockSize, BlockSize, BlockSize);
            }
        }

        private Graphics _Graphics;

        internal Graphics Graphics
        {
            get
            {
                return this._Graphics;
            }
            set
            {
                this._Graphics = value;
                this.Repaint();
            }
        }

        private const int BlockSize = 7;
        private const int InitialLength = 10;
        private const int DelayInterval = 300;

        private bool IsLiving = false;
        private Size Direction = new Size(1, 0);
        private Queue<Size> DirectionQueue = new Queue<Size>();
        private readonly Queue<Point> Points = new Queue<Point>();

    }
}
