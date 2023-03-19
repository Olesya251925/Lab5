using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CollectionStrings
{
    class Document
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к документу: ");
            string Path = Console.ReadLine();
            FileInfo fileInfo = new FileInfo(Path);
            if (!fileInfo.Exists)
            {
                Console.WriteLine("Такого документа не существует.");
            }
            int UserChoice = 0;
            while (UserChoice != 2)
            {
                Console.WriteLine("Меню\n1.Исправление номера.\n2.Заменить неправильные слова.");
                while (UserChoice < 1 || UserChoice > 2)
                {
                    if (int.TryParse(Convert.ToString(Console.ReadLine()), out UserChoice) == false)
                    {
                        Console.WriteLine("Неправильный ввод");
                    }
                }
                Console.Clear();
               
                switch (UserChoice)
                {
                    case 1:
                        Console.Clear();
                        EditPhoneNumbers.EditorOfPhoneNumbers(Path);
                        UserChoice = 0;
                        break;
                    case 2:
                        Console.Clear();
                        ChangingWords.SearchingWrongWords(Path);
                        UserChoice = 0;
                        break;
                }
                
            }
            Console.ReadKey();
        }

    }
}
