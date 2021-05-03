using System;
using System.Collections.Generic;
using System.Text;

namespace PHP_SRePS
{
    public class User
    {
        private int _id;
        private string _givenName;
        private string _surname;
        private string _authLevel; //Auth Levels |USER|MOD|ADMIN|
        private string _password;
    
        public int ID
        {
            get
            {
                return _id;
            }
        }
        public string GivenName
        {
            get
            {
                return _givenName;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
        }
        public string AuthLevel
        {
            get
            {
                return _authLevel;
            }
        }
        private string AuthLevelSet
        {
            set
            {
                _authLevel = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
        }

        public User(int ID, string fName, string sName, string Auth, string password)
        {
            _id = ID;
            _givenName = fName;
            _surname = sName;
            _password = password;
            if (Auth == "USER" || Auth == "MOD" || Auth == "ADMIN")
            {
                _authLevel = Auth;
            }
            else
            {
                _authLevel = "USER";
            }
        }
    }
}
