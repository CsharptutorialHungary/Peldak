using System;

namespace pelda_attribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class CreationDateAttribute: Attribute
    {
        public DateTime CreationDate
        {
            get;
        }

        //New kulcsszóval példányosítható típusok nem alkalmazhatóak
        //Attribútum tulajdsonágként vagy konstruktor argumentumként.
        public CreationDateAttribute(int year, int month, int day)
        {
            CreationDate = new DateTime(year, month, day);
        }
    }
}
