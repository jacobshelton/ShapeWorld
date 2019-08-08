namespace ShapeWorld.Domain.Models
{
  public class Triangle : Shape
  {
    public virtual double Length { get; set; }
    public virtual double Length2 { get; set; }
    public virtual double Length3 { get; set; }
    public virtual double Height { get; set; }

    public override double Perimeter() 
    { 
      return Length + Length2 + Length3; 
    }

    public override double Area() 
    {
      return 1/2 * Length * Height;
    }

    public Triangle() : base(3){}
  }
}