using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernButton : Button
{
    public int BorderRadius { get; set; } = 20;
    public Color BorderColor { get; set; } = Color.White;
    public int BorderSize { get; set; } = 2;

    public ModernButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.Size = new Size(150, 40);
        this.BackColor = Color.FromArgb(52, 152, 219);  
        this.ForeColor = Color.White;
        this.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.Cursor = Cursors.Hand;
    }

    private GraphicsPath GetRoundPath(RectangleF rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float r = radius;
        path.AddArc(rect.X, rect.Y, r, r, 180, 90);
        path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
        path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
        path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
        path.CloseFigure();
        return path;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        Graphics g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias; 

        RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
        RectangleF rectBorder = new RectangleF(1, 1, this.Width - 2, this.Height - 2);

        using (GraphicsPath pathSurface = GetRoundPath(rectSurface, BorderRadius))
        using (GraphicsPath pathBorder = GetRoundPath(rectBorder, BorderRadius - 1))
        using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
        using (Pen penBorder = new Pen(BorderColor, BorderSize))
        {
            this.Region = new Region(pathSurface);

            g.DrawPath(penSurface, pathSurface);

            if (BorderSize >= 1)
                g.DrawPath(penBorder, pathBorder);
        }
    }
}