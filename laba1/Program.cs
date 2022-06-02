using System;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа-калькулятор для расчета параллельных сопротивлений резисторов");
            Console.Write("Введите Количество резисторов: ");
            int count = int.Parse(Console.ReadLine());//поле для ввода кол-ва резисторов
            double[] resist = new double[count];//объявkение массива для сохранения сопротивления резисторов
            double denominator = 0; //переменная в которой хранится значение знаменателя в дроби в формуле

            for (int i = 0; i < count; i++)
            {
                Console.Write("R" + (i + 1) + ": ");
                resist[i] = double.Parse(Console.ReadLine());//ввод данных в массив
                resist[i] = 1 / resist[i];//расчет по заданной формуле
                denominator += resist[i];//находим значение знаменателя
            }
            double result = 1 / denominator;//итоговый подсчет: вычисляем сопротивление в резисторах
            double result1 = Math.Round(result, 4);

            Console.WriteLine("Ответ: " + result1);

            Console.ReadLine();
        }
    }
}
