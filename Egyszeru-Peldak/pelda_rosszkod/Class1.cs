namespace pelda_rosszkod
{
    public class Class1
    {
        public double Szamol(double mennyi, int tipus, int evek)
        {
            double e = 0;
            double k = (evek > 5) ? (double)5 / 100 : (double)evek / 100;
            if (tipus == 1)
            {
                e = mennyi;
            }
            else if (tipus == 2)
            {
                e = (mennyi - (0.1d * mennyi)) - k * (mennyi - (0.1d * mennyi));
            }
            else if (tipus == 3)
            {
                e = (0.7d * mennyi) - k * (0.7 * mennyi);
            }
            else if (tipus == 4)
            {
                e = (mennyi - (0.5d * mennyi)) - k * (mennyi - (0.5d * mennyi));
            }
            return e;
        }
    }
}
