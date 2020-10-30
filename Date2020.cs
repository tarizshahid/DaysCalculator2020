using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace DaysCalculator
{
    class Date2020
    {
        public string[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public int[] MonthDays = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public string[] Days = { "Sunday", "Monday", "Tuesday", "Wednesday ", "Thursday", "Friday", "Saturday" };
        int m, d = 0;
        public int Year = 2020;
        public Date2020()
        {
            d = m = 1;
        }
        public Date2020(int dd)
        {
            if (dd > 366 || dd < 1)
            {
                Console.WriteLine("Day is Out of range \nProgram Exiting...");
                Environment.Exit(0);
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    if (dd < MonthDays[i])
                    {
                        m = i;
                        if (dd == 0)
                        {
                            m = i;
                            dd = MonthDays[m - 1];
                        }
                        else
                            m = i + 1;
                        d = dd;
                        break;
                    }
                    
                    dd -= MonthDays[i];

                    if(i == 11)
                    {
                        d = 31;
                        m = 12;
                    }
                }
            }
        }
        public Date2020(int dd, int mm)
        {
            SetDate(dd, mm);
        }

        public void SetDate(int dd, int mm)
        {
            if (mm >= 1 && mm <= 12)
            {
                if (dd <= MonthDays[mm - 1] && dd >= 1)
                {
                    ;
                }
                else
                {
                    Console.WriteLine("Day/Month doesn't exist in specified Month\n Program Exiting...");
                    Environment.Exit(0);
                }
                m = mm;
                d = dd;
            }
            else
            {
                Console.WriteLine("Month doesn't exist in 2020\nProgram Exiting...");
                Environment.Exit(0);
            }
        }

        public void Print()
        {
            Console.Write(Days[(2 + ComputeDay()) % 7] + " , " + Months[m - 1] + " , " + d + " , " + Year);
        }

        public void PlusDay(int days)
        {

            int dd = 0; 
            dd= ComputeDay() + days;
            if(dd>366)
            {
                m = d = -1;
            }
            else
            {
                if (dd > 366 || dd < 1)
                {
                    Console.WriteLine("Day is Out of range \nProgram Exiting...");
                    Environment.Exit(0);
                }
                else
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (dd < MonthDays[i])
                        {
                            m = i;
                            if (dd == 0)
                            {
                                m = i;
                                dd = MonthDays[m - 1];
                            }
                            else
                                m = i + 1;
                            d = dd;
                            break;
                        }

                        dd -= MonthDays[i];

                        if (i == 11)
                        {
                            d = 31;
                            m = 12;
                        }
                    }
                }
            }
        }

        public int ComputeDay()                         //Print function just using return here
        {
            int X = 0;
            if (d > 365 || d < 1 || m < 1 || m > 12)
            {
                Console.WriteLine("Out of range.... \nProgram Exiting...");
                Environment.Exit(0);
            }
            else
            {
                for (int i = 0; i < m-1; i++)
                {
                    X += MonthDays[i];
                }
                X += d;
            }
            return X;
        }
    }
}
