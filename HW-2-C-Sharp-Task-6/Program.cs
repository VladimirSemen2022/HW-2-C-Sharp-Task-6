//Задание 6
//Пользователь с клавиатуры вводит некоторый текст. Приложение должно изменять регистр первой буквы
//каждого предложения на букву в верхнем регистре.
//Например, если пользователь ввёл: «today is a good day for walking. i will try to walk near the sea.»
//Результат работы приложения: «Today is a good day for walking. I will try to walk near the sea.»

using System;

namespace HW_2_C_Sharp_Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any text");
            string expres = Console.ReadLine();
            string[] data = expres.Split(new char[] { '.' });
            int leng = 0;
            string str0;
            string newExpres = "";
            for (int i=0; i < data.Length-1; i++)
            {
                data[i] = data[i].TrimStart();
                leng = data[i].Length;
                str0 = data[i].Substring(0, 1).ToUpper();
                data[i] = string.Concat(str0, data[i].Substring(1, leng - 1), ". ");
                newExpres += data[i];
            }
                Console.WriteLine(newExpres);
        }
    }
}
