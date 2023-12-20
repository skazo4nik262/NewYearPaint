

using System.Diagnostics;
using System.Drawing;

public class Programm
{
    static Graphics graphics =Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);


    static void Main(string[] args)
    {
        Console.ReadLine();
        FacadeNewYearPainter facade = new FacadeNewYearPainter(graphics);
        Sneg sneg = new Sneg();
        Yolka yolka = new Yolka();
        Girlanda girland = new Girlanda();
        Sneginki sneginki = new Sneginki();
        Podarok podarok = new Podarok();
        facade.AddPaintObject(sneg);
        facade.AddPaintObject(yolka);
        facade.AddPaintObject(girland);
        facade.AddPaintObject(sneginki);
        facade.AddPaintObject(podarok);
        facade.Create();
    }
}


