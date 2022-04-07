namespace Task_10_2_
{
    internal class A
    {
        protected double _a;
        protected double _b;
        public double C
        {
            get
            {
                do
                {
                    return _a + _b;
                }
                while (_a + _b < 0);
                {
                    return -(_a + _b);
                };
            }
        }
        public A(double a, double b)
        {
            _a = a;
            _b = b;
        }
    }
}