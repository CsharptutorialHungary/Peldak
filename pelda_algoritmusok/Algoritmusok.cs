using System;
using System.Collections.Generic;

namespace pelda_algoritmusok
{
    class Algoritmusok
    {
        public static void MinMax(int[] tomb, out int min, out int max)
        {
            int _min = tomb[0];
            int _max = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < _min) _min = tomb[i];
                if (tomb[i] > _max) _max = tomb[i];
            }
            min = _min;
            max = _max;
        }

        public static Dictionary<int, int> Statisztika(int[] tomb)
        {
            var stat = new Dictionary<int, int>();
            foreach (var elem in tomb)
            {
                if (stat.ContainsKey(elem)) stat[elem] += 1;
                else stat.Add(elem, 1);
            }
            return stat;
        }

        public static int Lineariskeres(int[] tomb, int elem)
        {
            int index = -1;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == elem)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int[] CseresRendez(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < tomb.Length; j++)
                {
                    if (tomb[i] < tomb[j])
                    {
                        var tmp = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = tmp;
                    }
                }
            }
            return tomb;
        }

        public static int[] MinimumRendez(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            for (int i=0; i<tomb.Length; i++)
            {
                var minimum = i;
                for (int j=i; j<tomb.Length; j++)
                {
                    if (tomb[j] < tomb[minimum]) minimum = j ;
                }
                if (tomb[i] != minimum)
                {
                    var tmp = tomb[i];
                    tomb[i] = tomb[minimum];
                    tomb[minimum] = tmp;
                }
            }
            return tomb;
        }

        public static int[] BuborekRendez(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            var csere = true;
            for (int i = tomb.Length -1; i >= 0 && csere; i--)
            {
                csere = false;
                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        int tmp = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = tmp;
                        csere = true;
                    }
                }
            }
            return tomb;
        }

        public static int[] Beszurorendez(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            for (var i = 0; i < tomb.Length - 1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (tomb[j - 1] > tomb[j])
                    {
                        var temp = tomb[j - 1];
                        tomb[j - 1] = tomb[j];
                        tomb[j] = temp;
                    }
                    j--;
                }
            }
            return tomb;
        }

        public static int[] ShellSort(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            int tavolsag = tomb.Length / 2;
            while (tavolsag > 0)
            {
                //ez egy módosított beszúró rendezés
                for (int i = 0; i < tomb.Length - tavolsag; i++)
                {
                    int j = i + tavolsag;
                    int tmp = tomb[j];
                    while (j >= tavolsag && tmp > tomb[j - tavolsag])
                    {
                        tomb[j] = tomb[j - tavolsag];
                        j -= tavolsag;
                    }
                    tomb[j] = tmp;
                }
                if (tavolsag == 2)  tavolsag = 1;
                else tavolsag = (int)(tavolsag / 2.2);
            }
            return tomb;
        }

        public static void Gyorsrendez(int[] tomb, int eleje = 0, int vege = -1)
        {
            if (vege == -1) vege = tomb.Length -1;
            if (eleje < vege)
            {
                int kozepe = Feloszt(tomb, eleje, vege);
                Gyorsrendez(tomb, eleje, kozepe - 1);
                Gyorsrendez(tomb, kozepe + 1, vege);
            }
        }

        private static int Feloszt(int[] tomb, int eleje, int vege)
        {
            int kozepe = tomb[vege];
            int kozepindex = eleje;

            for (int i = eleje; i < vege; i++)
            {
                if (tomb[i] <= kozepe)
                {
                    int temp = tomb[i];
                    tomb[i] = tomb[kozepindex];
                    tomb[kozepindex] = temp;
                    kozepindex++;
                }
            }

            int anotherTemp = tomb[kozepindex];
            tomb[kozepindex] = tomb[vege];
            tomb[vege] = anotherTemp;
            return kozepindex;
        }

        public static int BinarisKeres(int[] tomb, int keresettertek)
        {
            int eleje = 0;
            int vege = tomb.Length;
            while (eleje < vege)
            {
                int i = (eleje + vege) / 2;
                if (tomb[i] == keresettertek) return i;
                else if (tomb[i] < keresettertek) eleje = i + 1;
                else if (tomb[i] > keresettertek) vege = i - 1;
            }
            return -1;
        }
    }
}
