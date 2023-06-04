using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tervmintak.Builder;

sealed class Student
{
    public string Name { get; init; }
    public int Class { get; init; }
    public double Average { get; init; }
}

class StudentBuilder
{
    private string _name;
    private int _class;
    private double _average;

    public StudentBuilder()
    {
        _name = string.Empty;
    }

    public StudentBuilder New()
    {
        _name = string.Empty;
        _class = 9;
        _average = 0;
        return this;
    }

    public StudentBuilder New(Student student)
    {
        _name = student.Name;
        _class = student.Class;
        _average = student.Average;
        return this;
    }

    public StudentBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public StudentBuilder SetClass(int @class)
    {
        _class = @class;
        return this;
    }

    public StudentBuilder SetAverage(double average)
    {
        _average = average;
        return this;
    }

    public Student Build()
    {
        return new Student
        {
            Average = _average,
            Name = _name,
            Class = _class,
        };
    }
}