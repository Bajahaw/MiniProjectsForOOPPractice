namespace RhombusApp
{
    class Rhombus
    {
        private float a; //side length
        private float d1;
        private float d2;
        public Rhombus(float a, float d1)
        {
            this.a=a;
            this.d1=d1;
            this.d2= (float)Math.Sqrt(4 * Math.Pow(a, 2) - Math.Pow(d1, 2));
        }
        public float getA()
        {
            return a;
        }
        public float getD1()
        {
            return d1;
        }
        public float getD2()
        {
            return d2;
        }
        private double getArea()
        {
            return (d1*d2)/2;
        }
        private double getPerimeter()
        {
            return 4*a;
        }
        public void setD1(float d1)
        {
            this.d1=d1;
        }
        public void setA(float a)
        {
            this.a=a;
        }
        public override string ToString()
        {
            return "Rhombus side: "+a+" cm \nRhombus diognal 1: "+
            d1+" cm \nRhombus diognal 2: "+d2+" cm \nRhombus area: "+
            getArea()+" cm^2 \nRhombus perimeter: "+getPerimeter()+" cm";
        }
    }
}