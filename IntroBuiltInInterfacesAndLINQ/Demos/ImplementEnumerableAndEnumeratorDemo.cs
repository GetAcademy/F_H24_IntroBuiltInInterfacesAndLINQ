﻿using IntroBuiltInInterfacesAndLINQ.Enumerables;

namespace IntroBuiltInInterfacesAndLINQ.Demos
{
    internal class ImplementEnumerableAndEnumeratorDemo : IDemo
    {
        public DemoName Name => DemoName.Enumerable;

        public void Run()
        {
            var ints1 = new List<int> { 1, 2, 3 };
            var ints2 = new int[] { 1, 2, 3 };
            string text = "jkfdskj";
            bool b = false;
            var sequence = new DoublingNumberSequence(1, 1000);

            foreach (var element in sequence)
            {
                Console.WriteLine(element);
            }
        }
    }
}
