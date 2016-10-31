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
            if (this.DirectionQueue.Count == 0)
            {
                if ((dir.Width == 0) == (this.Direction.Width == 0))
                {
                    return;
                }
            }
            else
            {
                if ((dir.Width == 0) == (this.DirectionQueue.Last().Width == 0))
                {
                    return;
                }
            }
            if (this.DirectionQueue.Count >= 2)
            {
                var t = this.DirectionQueue.Peek();
                this.DirectionQueue.Clear();
                this.DirectionQueue.Enqueue(t);
            }
            this.DirectionQueue.Enqueue(dir);
        }

        public async void StartLife()
        {
            while (true)
            {
                await Task.Delay(DelayInterval);
                if (this.DirectionQueue.Count != 0)
                {
                    this.Direction = this.DirectionQueue.Dequeue();
                }
                this.Points.Enqueue(this.Points.Last() + this.Direction);
                this.Points.Dequeue();
                this.Repaint();
            }
        }

        private void Repaint()
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

        private Size Direction = new Size(1, 0);
        private Queue<Size> DirectionQueue = new Queue<Size>();
        private readonly Queue<Point> Points = new Queue<Point>();

    }
}
