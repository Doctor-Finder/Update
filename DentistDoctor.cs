﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_Finder_Windows_App
{
    class DentistDoctor : Doctor
    {
        public DentistDoctor(string name, int number, double price, string address) : base(name, number, price, address)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("number : " + number);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Doctor's address is : " + address);
            Console.WriteLine("Adress : " + address);
            Console.WriteLine("Specialized as : Dentist");

        }



    }
}