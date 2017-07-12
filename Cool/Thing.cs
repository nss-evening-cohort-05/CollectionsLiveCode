using System;

namespace HelloWorld.Cool 
{
    public class Thing 
    {
        public string StuffToPrint {get {return "This is a lot information at once!";}}
    
        public void PrintStuff(string text) 
        {
            if(text.Length > 5)
            {
                Console.WriteLine(text);
                return;
            }

            Console.WriteLine("Too Short!");
        }

        public int GetStuff()
        {
            return 4;
        }
    }
}