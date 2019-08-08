namespace ShapeWorld.Domain.Models
{
  public class Rectangle : Shape
  {
    public virtual double Length { get; set; }
    public virtual double Width { get; set; }

    public override double Perimeter() 
    { 
      return 2 * (Length + Width); 
    }

    public override double Area() 
    {
      return Length * Width;
    }

    public Rectangle() : base(4){}
  }
}