namespace ShapesTest
{
    public class Figure
    {
        protected double x{get; set;}
        protected double y{get; set;}
        protected string name{get; set;}

        public Figure(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public virtual double Area()
        {
            return x * y;
        } 
    }
    public class Rectangle : Figure
    {
        public Rectangle(double x, double y, string name) : base(x, y, name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public override double Area()
        {
            return base.Area();
        }
    }
    public class Triangle : Figure
    {
        public Triangle(double x, double y, string name) : base(x, y, name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public override double Area()
        {
            return 0.5 * x * y;
        }
    }
    public class Square : Figure
    {
        public Square(double x, string name, double y) : base(x, y, name)
        {
            this.x = x;
            this.name = name;
        }
        public override double Area()
        {
            return x * x;
        }
    }
    public class Cube : Figure
    {
        public Cube(double x, string name, double y) : base(x, y, name)
        {
            this.x = x;
            this.name = name;
        }
        public override double Area()
        {
            return 6.0 * x * x;
        }
    }
}