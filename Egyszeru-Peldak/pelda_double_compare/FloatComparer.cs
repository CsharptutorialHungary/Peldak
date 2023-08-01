namespace pelda_double_compare
{
    public class FloatComparer : IEqualityComparer<float>
    {
        private readonly float _tolerance;

        public FloatComparer(float tolerance)
        {
            _tolerance = tolerance;
        }

        public bool Equals(float x, float y)
        {
            if (float.IsNaN(x) && float.IsNaN(y))
                return true;

            float diff = Math.Abs(x - y);
            return diff < _tolerance;
        }

        public int GetHashCode(float obj)
        {
            return obj.GetHashCode();
        }
    }

    public class DoubleComparer : IEqualityComparer<double>
    {
        private readonly double _tolerance;

        public DoubleComparer(double tolerance)
        {
            _tolerance = tolerance;
        }

        public bool Equals(double x, double y)
        {
            if (double.IsNaN(x) && double.IsNaN(y))
                return true;

            double diff = Math.Abs(x - y);
            return diff < _tolerance;
        }

        public int GetHashCode(double obj)
        {
            return obj.GetHashCode();
        }
    }
}
