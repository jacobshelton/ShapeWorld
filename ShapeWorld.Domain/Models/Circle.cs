namespace ShapeWorld.Domain.Models
{
  public class Circle : Shape
  {
    public virtual double Radius { get; set; }

    public override double Perimeter() //Circumference
    { 
      return 2 * Radius * 3.14159; 
    }

    public override double Area() 
    {
      return Radius * Radius * 3.14159;
    }

    public Circle() : base(0) {}
  }
}