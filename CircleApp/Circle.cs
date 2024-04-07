namespace CircleApp
{
    class Circle
    {
        private double r;
        public Circle(double r)
        {
            this.r=r;
        }
        private double getArea()
        {
            return r * r * Math.PI;
        }
        private double getPerimeter()
        {
            return 2 * r * Math.PI;
        }
        public override string ToString()
        {
            return $"Circle radius: {r}\nCircle space: {getArea()}\nCircle perimeter: {getPerimeter()}";
        }
    }
}