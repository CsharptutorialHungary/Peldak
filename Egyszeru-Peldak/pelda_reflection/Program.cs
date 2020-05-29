using System;
using System.Reflection;

namespace pelda_reflection
{
    class Program
    {
        private static void ListMembers(MemberInfo[] members)
        {
            foreach (var member in members)
            {
                //tag neve
                Console.WriteLine("{0}", member.Name);
                //tag típusa
                Console.WriteLine("{0}", member.MemberType);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Type class1Type = typeof(Class1);

            MemberInfo[] members = class1Type.GetMembers();

            ListMembers(members);

            MemberInfo[] field = class1Type.GetMember("PrivateTulajdonsag", BindingFlags.NonPublic | BindingFlags.Instance);
            ListMembers(field);

            Console.ReadKey();
        }
    }
}
