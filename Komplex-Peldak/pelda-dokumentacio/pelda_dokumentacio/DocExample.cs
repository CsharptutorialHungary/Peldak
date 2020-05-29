using System;

/// <summary>
/// Sample namespace for documentation
/// </summary>
namespace pelda_dokumentacio
{
    /// <summary>
    /// A sample class for documentation generation
    /// </summary>
    public class DocExample
    {
        /// <summary>
        /// Add two numbers and round the result to 4 digits
        /// </summary>
        /// <param name="n1">number 1</param>
        /// <param name="n2">number 2</param>
        /// <returns>sum of n1 and n2 rounded to 4 digits</returns>
        public double AddAndRound(double n1, double n2)
        {
            return Math.Round(n1 + n2, 4);
        }

        /// <summary>
        /// Multiplies two numbers and round the result to 4 digits
        /// </summary>
        /// <param name="n1">number 1</param>
        /// <param name="n2">number 2</param>
        /// <returns>multiple of n1 and n2 rounded to 4 digits</returns>
        public double MultipyAndRound(double n1, double n2)
        {
            return Math.Round(n1 * n2, 4);
        }
    }
}
