﻿﻿using System;

namespace dependencyInjection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DiContainer container = new DiContainer();
            container.Register<IInterfaceA, ClassA>();
            container.Register<IInterfaceB, ClassB>();
            IInterfaceB classB = container.Resolve<IInterfaceB>();
            classB.DoB();
            
            Console.ReadKey();
        }
    }
}