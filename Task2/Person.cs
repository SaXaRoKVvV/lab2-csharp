using System;

namespace lab2
{

    public class Person
    {
        private Name _name;
        private int _height;
        private Person _father;

        public Name Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Person Father
        {
            get { return _father; }
            set { _father = value; }
        }

        public Person(Name name, int height)
        {
            _name = name;
            _height = height;
            _father = null;
        }
        
        public Person(Name name, int height, Person father)
        {
            _name = name;
            _height = height;
            _father = father;
        }
        
        public override string ToString()
        {
            if (_father != null)
            {
                if (string.IsNullOrWhiteSpace
                        (_name.Surname) &&
                    !string.IsNullOrWhiteSpace
                        (_father.Name.Surname))
                {
                    _name.Surname = _father.Name.Surname;
                }
                
                if (string.IsNullOrWhiteSpace
                        (_name.Patronymic) &&
                    !string.IsNullOrWhiteSpace
                        (_father.Name.FirstName))
                {
                    _name.Patronymic = 
                        _father.Name.FirstName + "ович";
                }
            }

            return _name.ToString() + ", рост: " + _height;
        }
    }
}