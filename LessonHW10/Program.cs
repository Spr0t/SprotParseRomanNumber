﻿using System;

namespace LessonHW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать функцию, которая принимает на вход строку -римское число, а возвращает это число в арабском виде.
            //Например, если передаём "XV" - должна вернуть 15, если передаём "IV" - должна вернуть 4.
            //Вот список римских символов и их отображение на арабские числа:

            //I - 1
            //V - 5
            //X - 10
            //L - 50
            //C - 100
            //D - 500
            //M - 1000

            //Варианты типа IIIV = 5 - 3 = 2 мы не рассматриваем.
            //"так, число 99 должно быть записано как XCIX, но не как IC."

            //Подсказка.Для решения надо реализовать два правила:
            //Правила записи чисел римскими цифрами:
            //-если большая цифра стоит перед меньшей, то они складываются(принцип сложения),
            //-если меньшая цифра стоит перед большей, то меньшая вычитается из большей(принцип вычитания).
 


            Console.WriteLine( $"Введите римское число: ");
            Console.WriteLine(RomanToNumber.Parse(Console.ReadLine()));

            Console.ReadLine();

            



        }
    }
}