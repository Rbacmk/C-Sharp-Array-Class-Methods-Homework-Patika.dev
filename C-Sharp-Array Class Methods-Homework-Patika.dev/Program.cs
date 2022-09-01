using System;

namespace C_Sharp_Array_Class_Methods_Homework_Patika.dev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Sınıfı Methodları
            // Sort sıralama işlemi

            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("*****SIRASIZ LİSTE*****");
            foreach (var sayi in sayiDizisi)
            {

                Console.WriteLine(sayi);
            }
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {

                Console.WriteLine(sayi);
            }
            //CLEAR -DEĞERİ SIFIRLIYOR.
            Console.WriteLine("ARRAY CLEAR");
            // sayiDizisi elemanlarını kullanarak 2.ndexten itibareb 2 tane elemanı sıfırlar.

            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {

                Console.WriteLine(sayi);
            }
            // reverse
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {

                Console.WriteLine(sayi);
            }
            //IndexOf



            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));
            // RESİZE
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {

                Console.WriteLine(sayi);
            }





        }

    }
# Ö-dev-1
    int sayı = 0;
    Console.WriteLine("lütfen bir sayı giriniz:");
             Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
           
            if (sayı % 2 == 1)
            {
                Console.WriteLine("Girdiğiniz sayı çift sayıdır.");
            }
            else
{
    Console.WriteLine("Girdiğiniz sayı çift sayı değildir !");
}
Console.ReadLine();
*************************************************************************************************************************************
 int sayiM = 0;
int sayiN = 0;
Console.WriteLine("lütfen m sayısını giriniz:");
Console.WriteLine("Lütfen n sayısını giriniz:");
Convert.ToInt32(Console.ReadLine());
Convert.ToInt32(Console.ReadLine());
if (sayiM == sayiN)
{
    Console.WriteLine("M ve N sayısı birbirine eşittir.");

}
else if (sayiM % sayiN == 1)
{
    Console.WriteLine(" M sayısı N sayısına tam bölünmüyor.");

}
else
{
    Console.WriteLine("M sayısı N sayısına tam bölünüyor.");
}
Console.ReadLine();
***********************************************************************************************************************************************************************
 int sayi = 0;
Console.WriteLine("Lütfen bir sayı giriniz:");
Convert.ToInt32(Console.ReadLine());
string kelime = "";
Console.WriteLine("Kelime giriniz:");
Console.ReadLine();
******************************************************************************************************************************************************************************************
 string cümle = "";
Console.WriteLine("Lütfen cümlenizi giriniz:");
Console.ReadLine();
var result = cümle.Length();

}
}
