using System;

namespace _06.Bit_Array
{
    class Program
    {
        static void Main()
        {
            BitArray myBitArr = new BitArray(5);
            myBitArr.SetBits(1, 2);
            Console.WriteLine(myBitArr.ToString());

            BitArray myBitArr1 = new BitArray(16);
            myBitArr1.SetBits(2, 4, 8);
            Console.WriteLine(myBitArr1.ToString());

            BitArray myBitArr2 = new BitArray(100001);
            myBitArr2.SetBits(2, 4, 8);
            Console.WriteLine(myBitArr2.ToString());

            BitArray myBitArr3 = new BitArray(64);
            myBitArr3.SetBits(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38,
                39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62);
            Console.WriteLine(myBitArr3.ToString());
            
            //The following should throw ArgumentException
            //BitArray myBitArr4 = new BitArray(100001);
            //myBitArr4.SetBits(2, 4, 8, 100001); 
            //Console.WriteLine(myBitArr4.ToString());
          
        }
    }
}
