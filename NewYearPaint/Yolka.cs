using System.Diagnostics;
using System.Drawing;

public class Yolka : ISmallPant

{
    

    public void Paint(Graphics graphics)
    {
        Pen pen = new Pen(Color.Brown, 10);
        Brush brush = new SolidBrush(Color.Green);
        graphics.FillPolygon(brush, new Point[]
        {
            new Point(50, 150),
            new Point(100, 100),
            new Point(150, 150),
        });
        graphics.FillPolygon(brush, new Point[]
        {
            new Point(50, 200),
            new Point(100, 100),
            new Point(150, 200),
        });
        graphics.DrawPolygon(pen, new Point[]
        {
            new Point(95, 205),
            new Point(95, 225),
            new Point(105, 225),
            new Point(105, 205),
        });

    }
}