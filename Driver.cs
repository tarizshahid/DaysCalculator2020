using System;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace DaysCalculator
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Month , Day of Month , Days After, seprated by space...");
            string[] arr = Console.ReadLine().Split(' ');
            Date2020 obj = new Date2020(Convert.ToInt32(arr[1]) , Convert.ToInt32(arr[0]));
            Console.Write(Convert.ToInt32(arr[2]) + " Days after ");
            obj.Print();
            Console.Write(" is ");
            obj.PlusDay(Convert.ToInt32(arr[2]));
            obj.Print();


        }
    }

}
