using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace pelda_regex_match
{
    class Program
    {
        const string emailpattern = @"[^@]+\@[^\.]+\..+";

        static IEnumerable<string> TestCases
        {
            get
            {
                yield return "user@test.com";
                yield return "test.com";
                yield return "user@.com";
                yield return "user@1234.com";
                yield return "12elemer@server.be";
                yield return "valaki@mymail.hu";
            }
        }

        static void Main(string[] args)
        {
            Regex expression = new Regex(emailpattern, RegexOptions.Compiled);

            foreach (var testcase in TestCases)
            {
                bool match = expression.IsMatch(testcase);
                Console.WriteLine("{0} match status: {1}", testcase, match);
            }

            Console.ReadKey();
        }
    }
}
