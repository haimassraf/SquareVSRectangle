namespace SquareVSRectangle
{
    public class Rectangle
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual double Area()
        {
            return Width * Height;
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
