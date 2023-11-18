using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        //Задача 1. Массив предназначен для хранения значений ростов двенадцати человек. С помощью датчика случайных чисел заполнить массив
        //целыми значениями, лежащими в диапазоне от 163 до 190 включительно. Вывести значения элементов с использованием цикла for.
        //Найти средний рост.

        //static int[] InPut()
        //{
        //    int[] omas = new int[12];
        //    Random random = new Random();
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        omas[i] = random.Next(163, 190);
        //    }
        //    return omas;
        //}
        // static void OutPut(int[] omas)
        //{
        //    for ( int i=0; i<omas.Length; i++)
        //    {
        //        Console.WriteLine($"omas[{i}]={omas[i]}");
        //    }
        //}

        // static int Average(int[] omas)
        //{
        //    int s = 0;
        //    for(int i=0; i<omas.Length; i++)
        //    {
        //        s += omas[i];
        //    }
        //    int average = s / omas.Length;
        //    return average;
        //}

        //static void Main(string[] args)
        //{
        //    int[] omas = InPut();
        //    OutPut(omas);
        //    Console.WriteLine($"Средний рост={Average(omas)}");
        //    Console.ReadKey();
        //}



        //Задача 2. 
        //Заполнить массив из восьми элементов следующими значениями с использованием явной инициализации:
        //первый элемент массива равен 37, второй — 0, третий — 50, четвертый — 46, пятый — 34, шестой — 46, седьмой — 0, восьмой —13.
        //Найти максимальный и минимальный элементы массива.


        //static int Min(int[] omas)
        //{
        //    int min = omas [0];
        //    for(int i=1; i<omas.Length; i++)
        //    {
        //        if(min>omas[i])
        //        {
        //            min = omas[i];
        //        }
        //    }
        //   return min;
        //}

        //static int Max(int[] omas)
        //{
        //    int max = omas[0];
        //    for (int i = 1; i < omas.Length; i++)
        //    {
        //        if (max < omas[i])
        //        {
        //            max = omas[i];
        //        }
        //    }
        //    return max;
        //}

        //static void Main ( string[] args)
        //{
        //    int[] omas = new int[] { 37, 0, 50, 46, 34, 46, 0, 13 };
        //    Console.WriteLine($"Минимальное значение: {Min(omas)}");
        //    Console.WriteLine($"Максимальное значение: {Max(omas)}");
        //    Console.ReadKey();
        //}


        //Задача 3.
        //Заполнить одномерный массив с клавиатуры и вывести элементы массива на экран в обратном порядке.
        //static int[] InPut()
        //{
        //    Console.Write("Введите n = ");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int[] omas = new int[n];
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        Console.Write($"omas[{i}]= ");
        //        omas[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    return omas;
        //}

        //static void OutPut(int[] omas)
        //{
        //    for (int i = omas.Length - 1; i >= 0; i--)
        //    {
        //        Console.WriteLine($"omas[{i}]={omas[i]}");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int[] omas = InPut();
        //    OutPut(omas);
        //    Console.ReadKey();
        //}




}
}

