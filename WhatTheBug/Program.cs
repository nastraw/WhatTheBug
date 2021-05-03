using System;

namespace WhatTheBug
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args)
            {
                default:
                    Console.WriteLine("Command not recognized");
                    break;
            }
        }
    }
}