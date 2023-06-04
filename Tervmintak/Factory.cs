using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tervmintak
{
    interface IUser
    {
        string Name { get; set; }
    }

    class Teacher : IUser
    {
        public string Name { get; set; }
    }

    class Student : IUser
    {
        public string Name { get; set; }
    }

    enum UserType
    {
        Student,
        Teacher,
    }

    class UserFactory
    {
        public IUser Create(UserType type, string name)
        {
            if (type == UserType.Student)
                return new Student { Name = name };
            else if (type == UserType.Teacher)
                return new Teacher { Name = name };
            else
                throw new InvalidOperationException("unknown type");
        }
    }
}
