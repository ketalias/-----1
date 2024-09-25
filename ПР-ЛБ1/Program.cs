using System;
using System.Collections.Generic;
//1 завдання, 2 варіант
class Program
{
    static void Main()
    {
        List<string> europeanCountries = new List<string>();
        europeanCountries.Add("Italy");
        europeanCountries.Add("Ukraine");
        europeanCountries.Add("Austria");
        europeanCountries.Add("France");
        europeanCountries.Add("Switzerland");

        Console.WriteLine("Елементи в прямому порядку: ");
        foreach(var item in europeanCountries)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Елементи в зворотньому порядку: ");
        europeanCountries.Reverse();
        foreach (var item in europeanCountries)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Кількість елементів у колекції: {europeanCountries.Count}");

        europeanCountries.Clear();

        Console.WriteLine($"Кількість елементів після очищення: {europeanCountries.Count}");
    }
}