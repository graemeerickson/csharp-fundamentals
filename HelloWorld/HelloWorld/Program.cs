﻿using System;

namespace HelloWorld
{
    public enum ImageOrientation
    {
        Landscape,
        Portrait
    }

    class Program
    {
        static void Main(string[] args)
        {
            var name = "Graeme Erickson";

            //for (var i = 0; i < name.Length; i++)
                //Console.WriteLine(name[i]);

            foreach (var character in name)
                Console.WriteLine(character);
        }
    }
}
