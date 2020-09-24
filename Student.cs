using System;
using System.Collections.Generic;
using System.Text;

namespace pratical_4_ex_1
{
    class Student : IStudent
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Native { get; set; }
        public string Class { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }
        public void Display()
        {
            Console.WriteLine($"Full name: {FullName}\nID: {ID}\nDate of Birth: {DateofBirth}\nNative: {Native}\nClass: {Class}\nPhoneNo: {PhoneNo}\nMobile: {Mobile}");
        }
    }
}
