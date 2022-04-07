namespace Task_10_2_
{
    internal class B : A
    {
        private double _d;
        public double C2
        {
            get
            {
                do
                {
                    return _a + _d;
                }
                while (_a - _d < 0);
                {
                    return -(_a - _d);
                };
            }
        }
        public B(double a, double b, double d) : base(a, b)
        {
            _d = d;
        }

    }
}