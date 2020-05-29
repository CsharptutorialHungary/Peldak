namespace pelda_cast_operatorok
{
    public struct Tort
    {
        private long _szamlalo;
        private long _nevezo;

        public Tort(long szamlalo, long nevezo)
        {
            _szamlalo = szamlalo;
            _nevezo = nevezo;
        }

        public static implicit operator Tort(int bemenet)
        {
            return new Tort(bemenet, 1);
        }

        public static explicit operator decimal(Tort bemenet)
        {
            return (decimal)bemenet._szamlalo / bemenet._nevezo;
        }
    }
}
