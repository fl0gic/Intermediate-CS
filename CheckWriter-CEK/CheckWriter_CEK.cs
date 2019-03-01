﻿using System;
using CheckWriter;

namespace CheckWriter_CEK
{
    class CheckWriter_CEK
    {
        static void Main(string[] args)
        {
            int width = 65;
            
            String date = DateTime.Today.ToString("MMMM dd, yyyy");
            Console.Out.WriteLine(new string(' ', width-date.Length)+date);
        }
    }

    class CheckUpdated : Check
    {   
        public override void Display()
        {
            int width = 65;
            
            string date = DateTime.Today.ToString("MMMM dd, yyyy");
            string amountString = "$ " + Amount;
                
            Console.Out.WriteLine(new string(' ', width-date.Length)+date);
            Console.Out.WriteLine("Pay to the ");
            Console.Out.WriteLine("Order of: "+Payee);
            Console.Out.WriteLine(new String(' ', width-amountString.Length)+amountString);
        }
    }
}