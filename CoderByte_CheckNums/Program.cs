using System;

namespace CoderByte_CheckNums
{
    class Program
    {
        //Have the function CheckNums(num1, num2) take both parameters being passed and return the string true if num2 is greater than num1, 
        //otherwise return the string false. 
        //If the parameter values are equal to each other then return the string -1. 


        static void Main(string[] args)
        {
            Console.WriteLine(CheckNums(4, 8));
            Console.ReadLine();
        }

        static string CheckNums(int num1, int num2)
        {
            string _string = "";
            if (num2 > num1)
            {
                _string = "true";
            } else
            {
                _string = "false";
            }
            if (num1 == num2)
            {
                _string = "-1";
            }

            return _string;
        }

    }
}
