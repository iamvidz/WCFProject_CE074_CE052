using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    public class User
    {
        string _email;
        string _fname;
        string _lname;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string fname
        {
            get { return _fname; }
            set { _fname = value; }
        }
        public string lname
        {
            get { return _lname; }
            set { _lname = value; }
        }

        string _role;
        public String role
        {
            get { return _role; }
            set { _role = value; }
        }
    }
}
