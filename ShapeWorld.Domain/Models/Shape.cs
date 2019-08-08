namespace ShapeWorld.Domain.Models
{
  public abstract class Shape
  {
    //properties
    public int NumberOfEdges { get; }

    //methods
    public virtual double Perimeter()
    {
      return 0;
    }
    public abstract double Area();
    //public abstract double Volume();

    //controllers
    public Shape(int edges)
    {
      NumberOfEdges = edges;
    }
  }
}