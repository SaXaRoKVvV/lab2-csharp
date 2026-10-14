using System;

namespace lab2
{

    public class Name
    {
        private string _surname;
        private string _firstName;
        private string _patronymic;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }
        
        public Name(string surname, string firstName, string patronymic)
        {
            _surname = surname;
            _firstName = firstName;
            _patronymic = patronymic;
        }
        
        public Name(string surname, string firstName)
        {
            _surname = surname;
            _firstName = firstName;
            _patronymic = null;
        }
        
        public Name(string firstName)
        {
            _surname = null;
            _firstName = firstName;
            _patronymic = null;
        }
        
        public override string ToString()
        {
            string result = "";

            if (!string.IsNullOrWhiteSpace(_surname))
            {
                result += _surname;
            }

            if (!string.IsNullOrWhiteSpace(_firstName))
            {
                if (result.Length > 0)
                {
                    result += " ";
                }
                result += _firstName;
            }

            if (!string.IsNullOrWhiteSpace(_patronymic))
            {
                if (result.Length > 0)
                {
                    result += " ";
                }
                result += _patronymic;
            }

            return result;
        }
    }
}