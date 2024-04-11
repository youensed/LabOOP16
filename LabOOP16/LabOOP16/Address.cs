using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP16
{
    internal class Address//клас адреса
    {
        public string City { get; set; }//властивість яка отримує дані про місто
        public string Street { get; set; }// властивість яка отримує дані про вулицю
        public int Number { get; set; }//властивість яка отримує дані про число

        public Address()// конструктор 
        {
            City = string.Empty;
            Street = string.Empty;
            Number = 0;
        }

        public Address(string city, string street, int number)// конструктор з аргументами
        {
            City = city;
            Street = street;
            Number = number;
        }

        public Address(int number)// конструктор з аргументами
        {
            Number = number;
        }
        public static void Remove(Address other)//метод видалення об'єкта
        {
            other = null;
        }
    }
}

