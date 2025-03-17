using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uplaba1
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int YearFounded { get; set; }

        public Company(string name, string address, int yearFounded)
        {
            Name = name;
            Address = address;
            YearFounded = yearFounded;
        }

        //public void DisplayInfo()
        //{
        //    Console.WriteLine($"Компания: {Name}");
        //    Console.WriteLine($"Адрес: {Address}");
        //    Console.WriteLine($"Год основания: {YearFounded}");
        //}

        internal class Program
    {
        static void Main(string[] args)
        {
                {
                    //Company company = new Company(" АААААА", "г. Полоцк, ул. Октябрьская, д. 57", 2000);
                    //company.DisplayInfo();
                }
            }
    }
}
   
}
