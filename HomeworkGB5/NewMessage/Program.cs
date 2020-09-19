﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMessage
{
    class Program
    {
        //      Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        //      а) Вывести только те слова сообщения,  которые содержат не более n букв.
        //      б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        //      в) Найти самое длинное слово сообщения.
        //      г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        //      д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст,
        //       в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
        //      Комышан Виктор

        static void Main(string[] args)
        {
            // Задание А
            Console.WriteLine("Введите строку");
            string[] message = Console.ReadLine().Split(' ');
            Message.NLetters(message, 5);

            // Задание Б
            Message.DelNEndings(message, "n");

            // Задание В
            Message.MaxLengthWord(message);

            // Задание Г
            Message.MaxWordsString(message);
            Console.ReadLine();


        }
    }
}
