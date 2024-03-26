namespace CircleApp
{
    class Circle
    {
        private double r;
        public Circle(double r)
        {
            this.r=r;
        }
        public double getSpace()
        {
            return r * r * Math.PI;
        }
        public double getPerimeter()
        {
            return 2 * r * Math.PI;
        }
        public override string ToString()
        {
            return $"Circle radius: {r}\nCircle space: {getSpace()}\nCircle perimeter: {getPerimeter()}";
        }
    }
}