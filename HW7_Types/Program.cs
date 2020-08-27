using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Equation(a); // изменение значимого типа данных
            Console.WriteLine("a= " + a);
            Console.WriteLine();
            string str = "5";
            EquationObject(str);
            Console.WriteLine("str= " + str);
            Console.WriteLine();
            Console.WriteLine("PassingRefByVal");
            
            int[] arr = { 1, 4, 5 };
            System.Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", arr[0]);

            PassingRefByVal(arr);
            System.Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr[0]);

            /* Вывод:
                Внутри Main, ДО вызова метода, первый елемент: 1
                Внутри метода, первый елемент: -3
                Внутри Main, ПОСЛЕ вызова метода, первый елемент: 888
            */


            int[] arr2 = { 1, 4, 5 };
            System.Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", arr2[0]);

            PassingRefByRef(ref arr2);
            System.Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr2[0]);

            /* Вывод:
            Внутри Main перед вызовом метода первым элементом является: 1
            Внутри метода первый элемент: -3
            Внутри Main после вызова метода первый элемент: -3
            */
        }

        static void Equation(int a)
        {
            int b = 6;
            int c = b; //6
            a = c; // b=36 c=6
            Console.WriteLine("a= " + a + " b= " + b + " c= " + c);
        }
        static void EquationObject(string str)
        {
            string b = "6";
            string c = b; //6
            str = c; // b=36 c=6
            Console.WriteLine("str= " + str + " b= " + b + " c= " + c);
        }

        static void PassingRefByVal(int[] pArray)
        {
            pArray[0] = 888;  // Это вызывает изменения оригинального параметра.
            pArray = new int[5] { -3, -1, -2, -3, -4 };   // Тут изменяется локально.
            System.Console.WriteLine("Inside the method, the first element is: {0}", pArray[0]);
        }
        static void PassingRefByRef(ref int[] pArray)
        {
            // Оба следующих изменения повлияют на исходные переменные:
            pArray[0] = 888;
            pArray = new int[5] { -3, -1, -2, -3, -4 };
            System.Console.WriteLine("Inside the method, the first element is: {0}", pArray[0]);
        }
    }
}
