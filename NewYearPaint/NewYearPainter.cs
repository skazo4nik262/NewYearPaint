using System.Drawing;

public class FacadeNewYearPainter
{
    
    private Graphics graphics;
    private List<ISmallPant> list = new List<ISmallPant>();

    public FacadeNewYearPainter(Graphics graphics) 
    {
        this.graphics = graphics;
    }

    public void AddPaintObject(ISmallPant iSmallPant)
    {
        list.Add(iSmallPant);
    }

    
    public void Create()
    {
        for(int i = 0; i < 5; i++)
        {
            list[i].Paint(graphics);
        }
        
       
    }
}