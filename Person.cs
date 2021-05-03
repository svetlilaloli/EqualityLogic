using System;

namespace EqualityLogic
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }
        public bool Equals(Person other)
        {
            return other != null && Name.ToLower() == other.Name.ToLower() && Age == other.Age;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Name.ToLower().GetHashCode();
            hash = hash * 23 + Age.GetHashCode();
            return hash;
        }

        public int CompareTo(Person other)
        {
            int result = Name.ToLower().CompareTo(other.Name.ToLower());
            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
            }
            return result;
        }
    }
}
