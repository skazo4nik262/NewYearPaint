using System.Diagnostics;
using System.Drawing;

public class Podarok : ISmallPant
{


    public void Paint(Graphics graphics)
    {

        Brush redBrush = new SolidBrush(Color.Red);
        Brush yellowBrush = new SolidBrush(Color.Yellow);
        Brush blackBrush = new SolidBrush(Color.Black);

        graphics.FillRectangle(redBrush, 600, 300, 130, 130);
        graphics.FillRectangle(yellowBrush, 650, 300, 30, 130);
        graphics.FillRectangle(yellowBrush, 600, 350, 130, 30);

        graphics.FillPolygon(yellowBrush, new Point[] { new Point(665, 300), new Point(615, 270), new Point(647, 260) });
        graphics.FillPolygon(yellowBrush, new Point[] { new Point(665, 300), new Point(715, 273), new Point(683, 261) });

        graphics.FillPolygon(yellowBrush, new Point[] { new Point(658, 292), new Point(707, 268), new Point(688, 264) });
        graphics.FillPolygon(yellowBrush, new Point[] { new Point(665, 300), new Point(715, 273), new Point(683, 261) });
    }
}
