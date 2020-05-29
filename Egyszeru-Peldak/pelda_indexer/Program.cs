using System;

namespace pelda_indexer
{
    class Program
    {
        class IntToString
        {
            public string this[int i]
            {
                get
                {
                    switch (i)
                    {
                        case 0:
                            return "Nulla";
                        case 1:
                            return "Egy";
                        case 2:
                            return "Kettő";
                        case 3:
                            return "Három";
                        case 4:
                            return "Négy";
                        case 5:
                            return "Öt";
                        case 6:
                            return "Hat";
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                var conv = new IntToString();
                for (int i=0; i<8; i++)
                {
                    Console.WriteLine("{0} = {1}", i, conv[i]);
                }
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Ez már nincs implementálva");
            }
            Console.ReadKey();
        }
    }
}
