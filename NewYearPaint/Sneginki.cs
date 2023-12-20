using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml.XPath;

public class Sneginki : ISmallPant

{
    Random random = new Random();
    int[] cord = new int[] { 0, 0, 5, 84, 56, 24, 78 ,23 ,454 ,1 ,54 ,45 , 32, 64, 546, 32, 8, 51, 87 };
    public void Paint(Graphics graphics)
    {
        Pen pen = new Pen(Color.LightBlue, 3);
        for (int i = 0; i < 10; i++)
        {
            int rnd = random.Next(0, cord.Length - 1);
            int rnd2 = random.Next(0, cord.Length - 1);
            int x = cord[rnd];
            int y = cord[rnd2];
            graphics.DrawLine(pen, x, y, x + 25, y + 25);
            graphics.DrawLine(pen, x + 25, y, x , y + 25);

        }
        Console.ReadLine();
    }
}