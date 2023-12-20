using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;

public class Girlanda : ISmallPant

{


    public void Paint(Graphics graphics)
    {
        Pen pen = new Pen(Color.Gray, 5);
        Brush brushg = new SolidBrush(Color.Green);
        Brush brushb = new SolidBrush(Color.Blue);
        Brush brushr = new SolidBrush(Color.Red);
        graphics.DrawCurve(pen, new Point[]
        {
            new Point(300, 300),
            new Point(350, 250),
            new Point(400, 300),
            new Point(450, 250),
            new Point(500, 350),
        });
        graphics.FillEllipse(brushg, 350, 250, 10, 10);
        graphics.FillEllipse(brushb, 400, 300, 10, 10);
        graphics.FillEllipse(brushr, 450, 250, 10, 10);

    }
}