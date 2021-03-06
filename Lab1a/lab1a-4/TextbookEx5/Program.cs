﻿using System.Collections;
using static System.Console;

namespace TextbookEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Person("Rual", 30));
            list.Add(new Person("Donna", 25));
            list.Add(new Person("Mary", 27));
            list.Add(new Person("Ben", 44));
            WriteLine("Unsorted people:");
            //for loops iterate through the arraylist and cast list objects to the person class
            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"{(list[i] as Person).Name } ({(list[i] as Person).Age })");
            }
            WriteLine();
            WriteLine(
               "People sorted with default comparer (by age):");
            //when sort() is called it uses the CompareTo function in the person class by default to sort by age
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"{(list[i] as Person).Name } ({(list[i] as Person).Age })");
            }
            WriteLine();
            WriteLine(
               "People sorted with nondefault comparer (by name):");
            //This time the Sort method does a nondefault comparison using the 
            //Compare method in the PersonComparerName Class
            list.Sort(PersonComparerName.Default);
            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"{(list[i] as Person).Name } ({(list[i] as Person).Age })");
            }
            ReadKey();
        }
    }
}
