using System.Diagnostics;
using System.Drawing;

public class Sneg : ISmallPant

{


    public void Paint(Graphics graphics)
    {
        Brush brush = new SolidBrush(Color.White);
        graphics.FillPolygon(brush, new Point[]
        {
            new Point(0, 0),
            new Point(0, 1000),
            new Point(1000, 1000),
            new Point(1000, 0),
        });

    }
}