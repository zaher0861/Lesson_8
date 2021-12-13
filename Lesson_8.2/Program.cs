using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Создаем файл и вносим в него 10 случайных чисел от 0 до 50
            int[] array = new int[10];
            Random a = new Random();
            string path = "Безымянный файл.txt";
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < 10; i++)
            {
                array[i] = a.Next(0, 50);
                sw.Write("{0}  ", array[i]);
            }
            sw.Close();
            #endregion
            #region Извлекаем из файла числа, выносим их на коносоль, и считаем сумму
            int S = 0;
            StreamReader sr = new StreamReader(path);
            string numbers = sr.ReadToEnd();
            Console.WriteLine(numbers);
            string[] numbersArray = numbers.Split();
            foreach (string n in numbersArray)
            {
                if (n != "")
                {
                    int i = Convert.ToInt32(n);
                    S += i;
                }
            }
            Console.WriteLine("Сумма чисел равна {0}", S);
            #endregion
            Console.ReadKey();
        }
    }
}
