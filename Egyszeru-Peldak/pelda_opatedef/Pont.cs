namespace pelda_opatedef
{
    class Pont
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Pont(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Pont(int x)
        {
            X = x;
            Y = 0;
        }

        //toString implementáció
        public override string ToString()
        {
            return string.Format("X: {0}, Y: {0}", X, Y);
        }

        //Az equals miatt ajánlatos, meg amúgy is
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ X.GetHashCode();
                hash = (hash * 16777619) ^ Y.GetHashCode();
                return hash;
            }
        }

        //equals implementáció a hash miatt, meg amúgy is
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Pont masik = obj as Pont;
            if (masik == null) return false;
            return X == masik.X && Y == masik.Y;
        }

        public static Pont operator +(Pont a, Pont b)
        {
            return new Pont(a.X + b.X, a.Y + b.Y);
        }

        public static Pont operator -(Pont a, Pont b)
        {
            return new Pont(a.X + b.X, a.Y + b.Y);
        }

        // egy változós művelet esetén csak egy argumentum kell
        public static Pont operator ++(Pont a)
        {
            return new Pont(a.X + 1, a.Y + 1);
        }

        //ha a ++ operátort átdefiniáljuk, akkor konzisztencia miatt
        //a -- operátort is érdemes
        public static Pont operator --(Pont a)
        {
            return new Pont(a.X - 1, a.Y - 1);
        }

        public static bool operator == (Pont a, Pont b)
        {
            //equals implementációra támaszkodunk, mert már egyszer megvan
            //és nem találjuk fel újra a kereket!
            return a.Equals(b);
        }

        public static bool operator !=(Pont a, Pont b)
        {
            //szintén
            return !a.Equals(b);
        }


        //implicit konvertálás
        public static implicit operator Pont(int i)
        {
            return new Pont(i);
        }

        public static implicit operator int(Pont p)
        {
            return p.X;
        }

        //explicit konvertálás
        public static explicit operator bool(Pont p)
        {
            return (p.X != 0 || p.Y != 0);
        }
    }
}
