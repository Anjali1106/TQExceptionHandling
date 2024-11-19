using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class AgeException : Exception
    {
        public AgeException(string msg) : base(msg)
        {

        }
    }

    public class NameException : Exception
    { 
        public NameException(string msg) : base(msg)
        {

        }
    }


    public class Users
    {
        private int age;
        private string name;
        public Users(int age, string name)
        {
            if (age >= 18)
            {
                this.age = age;

            }
            else
            {
                throw new AgeException(age + " age is not allowed");// explict call to exception using throw
            }


            //if(IsNullOrEmpty()) name is required
            if (string.IsNullOrEmpty(name))
            {
                //this.name = name;
                throw new NameException(name + " name is not allowed");

            }
            else {
                //throw new NameException(name + " name is not allowed");
                this.name = name;


            }
        }
    }


}
