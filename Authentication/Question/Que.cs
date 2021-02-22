using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    public class Que
    {
        string _question;
        string _op1;
        string _op2;
        string _op3;
        string _op4;
        string _ans;

        public string QuestionVal
        {
            get { return _question; }
            set { _question = value; }
        }
        public string Option1
        {
            get { return _op1; }
            set { _op1 = value; }
        }
        public string Option2
        {
            get { return _op2; }
            set { _op2 = value; }
        }
        public string Option3
        {
            get { return _op3; }
            set { _op3 = value; }
        }
        
        public string Option4
        {
            get { return _op4; }
            set { _op4 = value; }
        }
        
        public string Answer
        {
            get { return _ans; }
            set { _ans = value; }
        }
    }
}
