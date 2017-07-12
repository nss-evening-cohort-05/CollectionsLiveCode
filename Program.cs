using System;
using System.Collections.Generic;
using HelloWorld.Cool;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {   
            var myStringArray = new string[10];

            // var myList = new List<int>();
            // myList.Add(1);
            // myList.Add(2);
            // myList.Add(3);
            // myList.Add(4);
            // myList.Add(5);

            // myList.Remove(3);
            // var secondList = new List<int>() {6,7,8};
            // myList.AddRange(secondList);
            // myList.InsertRange(0,secondList);

            // foreach (var item in myList)
            // {
            //     Console.WriteLine(item);                
            // }

            var myFirstDictionary = new Dictionary<string,DateTime>();

            myFirstDictionary.Add("Nathan's Birthday",DateTime.Parse("5/27/1986"));
            myFirstDictionary.Add("Kate's Birthday",DateTime.Parse("8/13/1987"));

            foreach (var item in myFirstDictionary)
            {
                Console.WriteLine($"{item.Key} is {item.Value}");
            }

            Thing variableName = new Thing();
            //Console.WriteLine(variableName.GetStuff());
            /*Console.WriteLine(variableName.StuffToPrint);*/
        }
    }
}
