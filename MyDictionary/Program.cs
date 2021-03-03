using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> ogrenci = new MyDictionary<string,string>();
            ogrenci.Add("Masa","Table");
            ogrenci.Add("Kalem", "Pen");
            ogrenci.Add("Ayakkabı", "Shoe");
            ogrenci.Add("Bilgisayar", "Computer");

        }
    }
}
