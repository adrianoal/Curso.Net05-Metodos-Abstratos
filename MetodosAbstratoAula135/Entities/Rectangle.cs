namespace MetodosAbstratoAula135.Entities.Enums
{
    class Rectangle : Shape
    {
        public double Width { get; set; } // Largura
        public double Height { get; set; } // Altura

        public Rectangle(double height, double width, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
