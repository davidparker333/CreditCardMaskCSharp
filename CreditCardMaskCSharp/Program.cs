using System;
using System.Collections.Generic;

namespace CreditCardMaskCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct.
            //However, since someone could look over your shoulder, you don't want that shown on your screen.Instead, we mask it.
            //Your task is to write a function maskify, which changes all but the last four characters into '#'.

            string cc = "4556364607935616";

            Console.WriteLine(Maskify(cc));

        }

        public static string Maskify(string cc)
        {
            if(cc.Length < 4)
            {
                return cc;
            }
            return cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#');
        }
    }
}
