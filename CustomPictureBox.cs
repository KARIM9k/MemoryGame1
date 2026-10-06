using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MemoryGame1 
{
    public class RoundedPictureBox : PictureBox
    {
        private int _cornerRadius = 20;
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;
                this.Invalidate();
            }
        }

        private int _borderSize = 3;
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }

        private Color _borderColor = Color.FromArgb(200, Color.White);
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        public RoundedPictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent; 
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (this.ClientRectangle.Width <= 1 || this.ClientRectangle.Height <= 1) return;

            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rect = new RectangleF(
                _borderSize / 2f,
                _borderSize / 2f,
                this.ClientRectangle.Width - _borderSize,
                this.ClientRectangle.Height - _borderSize);

            if (_borderSize > 0)
            {
                using (GraphicsPath pathBorder = GetRoundedRectPath(rect, _cornerRadius))
                using (Pen pen = new Pen(_borderColor, _borderSize))
                {
                    pe.Graphics.DrawPath(pen, pathBorder);

                    using (Region region = new Region(pathBorder))
                    {
                        this.Region = region;
                    }
                }
            }
            else 
            {
                using (GraphicsPath pathFlat = GetRoundedRectPath(this.ClientRectangle, _cornerRadius))
                using (Region region = new Region(pathFlat))
                {
                    this.Region = region;
                }
            }
        }

        private GraphicsPath GetRoundedRectPath(RectangleF rect, float radius)
        {
            float diameter = radius * 2.0f;
            SizeF size = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(rect.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.AddArc(arc, 180, 90);

            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
        }
    }
}