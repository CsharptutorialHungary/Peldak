using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tervmintak.Prototype
{
    public interface ICloneable<out T> : ICloneable where T : class
    {
        T DeepClone();
    }

    public sealed class Student : ICloneable<Student>
    {
        public string Name { get; init; }
        public int Class { get; init; }
        public double Average { get; init; }

        public Student()
        {
            Name = string.Empty;
        }

        public Student DeepClone()
        {
            return new Student
            {
                Name = new string(Name),
                Class = Class,
                Average = Average
            };
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
