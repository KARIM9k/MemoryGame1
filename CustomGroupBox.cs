using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomGroupBox : GroupBox
{
    public int BorderRadius { get; set; } = 15; 
    public Color BorderColor { get; set; } = Color.FromArgb(0, 122, 204); 
    public int BorderThickness { get; set; } = 2; 

    public CustomGroupBox()
    {
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        using (SolidBrush bgBrush = new SolidBrush(this.BackColor))
        {
            g.FillRectangle(bgBrush, this.ClientRectangle);
        }

        SizeF textSize = g.MeasureString(this.Text, this.Font);
        int rectY = (int)(textSize.Height / 2);
        Rectangle rect = new Rectangle(0, rectY, this.Width - 1, this.Height - rectY - 1);

        using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
        {
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                g.DrawPath(pen, path);
            }
        }

        if (!string.IsNullOrEmpty(this.Text))
        {
            Rectangle textRect = new Rectangle(BorderRadius, 0, (int)textSize.Width + 6, (int)textSize.Height);
            using (SolidBrush bgTextBrush = new SolidBrush(this.BackColor))
            {
                g.FillRectangle(bgTextBrush, textRect);
            }
            using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
            {
                g.DrawString(this.Text, this.Font, textBrush, BorderRadius + 3, 0);
            }
        }
    }

    private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float diameter = radius * 2F;

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        return path;
    }
}