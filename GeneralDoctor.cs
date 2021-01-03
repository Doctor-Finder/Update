using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_Finder_Windows_App
{
    class GeneralDoctor : Doctor
    {
        public GeneralDoctor(string name, int number, double price, string address) : base(name, number, price, address)
        {
             name = "Mohamed Abdel3aiz Selim";
             number = 010088894;
             price = 350;
            address = "Km 8, Cairo Suez Desert Rd. El Nakhil Suburb, 5th District, El sherouk city";
            

            Console.WriteLine("Name : " + name);
            Console.WriteLine("number : " + number);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Doctor's address is : " + address);
            Console.WriteLine("Adress : " + address);
            Console.WriteLine("Specialized as : General");

        }


    }
    
    }

