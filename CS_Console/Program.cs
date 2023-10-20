using System;
using CS_Console;
namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main()
        {
            LinkList<int> ints = new();
            ints.PushBack(12);
            ints.PushBack(13);
            Console.WriteLine(ints.PopBack());
            Console.ReadKey();
        }
    }
}