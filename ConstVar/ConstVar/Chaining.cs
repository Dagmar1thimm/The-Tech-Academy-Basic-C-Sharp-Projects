using System;
using System.Collections.Generic;
using System.Text;

namespace ConstVar
{
    public class Chaining
    {
        int myNumber;
        string myString;

        public Chaining()
        {
            this.myNumber = 0;
            this.myString = "empty";
        }

        public Chaining(int num) : this()
        {
            this.myNumber = num;
        }

        public Chaining(string str) : this()
        {
            this.myString = str;
        }

        public void setNumber(int num)
        {
            this.myNumber = num;
        }

        public void setString(string str)
        {
            this.myString = str;
        }

        public void printMe()
        {
            Console.WriteLine("The object contains number = " + this.myNumber + ", string = '" + this.myString + "'");
        }

    }
}
