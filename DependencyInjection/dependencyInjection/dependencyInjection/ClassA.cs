using System;

namespace dependencyInjection
{
    public class ClassA : IInterfaceA
    {
        public void DoA()
        {
            Console.WriteLine("Do A");
        }
    }
}