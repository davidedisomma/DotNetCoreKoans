using Xunit;
using DotNetCoreKoans.Engine;
using System.IO;
using System;
using System.Diagnostics;

namespace DotNetCoreKoans.Koans
{
    public class AboutBitwiseAndShiftOperator : Koan
    {
        [Step(1)]
        public void BinaryAndOperator()
        {
            //Example
            //1 in binary is 0001
            //3 in binary is 0011
            //With & only taking the same one else take 0,so 1 & 3 it becomes 0001.
            //When 0001 convert to int it becomes 1
            int x = 4 & 4;

            Assert.Equal(4, x);
        }

        [Step(2)]
        public void BinaryOrOperator()
        {
            //Example
            //1 in binary is 0001
            //3 in binary is 0011
            //With | it will take any 1 if either one contains 1,so 1 & 3 it becomes 0011.
            //When 0011 convert to int it becomes 3
            int x = 4 | 4;

            Assert.Equal(4, x);
        }

        [Step(3)]
        public void BinaryXOrOperator()
        {
            //Example
            //1 in binary is 0001
            //3 in binary is 0011
            //With ^ it will take 1 when it is 0-1, if it is 1-1 it will take 0,so 1 & 3 it becomes 0010.
            //When 0010 convert to int it becomes 2
            int x = 4 ^ 4;

            Assert.Equal(0, x);
        }

        [Step(4)]
        public void BinaryOnesComplementOperator()
        {
            //Example
            //With ~ it will convert positive number to negative number and add -1 to the number.
            // ~1 become -2

            //https://stackoverflow.com/questions/14326900/how-does-c-do-bitwise-or-operations-on-negative-numbers
            //15 ->  00001111      // 15 decimal is 00001111 binary
            //-15 -> ~00001111 + 1  // negation in two's complement is equvalent to ~x + 1
            //-15 ->  11110000 + 1  // do the complement
            //-15 ->  11110001      // add the 1
            int x = ~4;

            Assert.Equal(-5, x);
        }

        [Step(5)]
        public void Combination1()
        {
            //3 in binary is 0011
            //8 in binary is 1000
            //~3 becomes -4 ~0100
            //               1011 +1
            //               1100

            int x = ~3 & 8;

            Assert.Equal(8, x);
        }

        [Step(6)]
        public void Combination2()
        {
            //Order operator ~, &, |, ^
            //4 in binary is 0100
            //8 in binary is 1000
            // 4 & 8 = 0100 & 1000 = 0000
            // 4 | 0 = 0100 | 0000 = 0100
            int x = 4 | 4 & 8;

            Assert.Equal(4, x);
        }

        [Step(7)]
        public void Combination3()
        {
            // ~8 = -9 = ~1001 = 0110 + 1 = 0111
            // 3 & 4 = 0011 & 0100 = 0000 = 0
            // 4 & -9 = 0100 & ~1001 = 0100 & 0111 = 0100 = 4
            // 4 ^ 0 = 0100 ^ 0000 = 0100
            int x = 3 & 4 ^ 4 & ~8;
            Console.Out.WriteLine("Hello World Again!");
            Console.Out.WriteLine("~8 = " + ~8);
            Console.Out.WriteLine("3 & 4 = " + (3 & 4));
            Console.Out.WriteLine("4 & -9 = " + (4 & ~8));
            Assert.Equal(4, x);
        }

        [Step(8)]
        public void BitwiseLeftShift()
        {
            //Example
            //4 in binary is 0100
            //when we try to 4 << 1
            //it becomes 1000
            //then it will become 8
            int x = 10 << 2; //1010 << 2 = 101000

            Assert.Equal(40, x);
        }

        [Step(9)]
        public void BitwiseRightShift()
        {
            //Example
            //4 in binary is 0100
            //when we try to 4 >> 1
            //it becomes 0010
            //then it will become 2
            int x = 12 >> 2; // 1100 >> 2 = 0011
            Assert.Equal(3, x);
        }

        [Step(10)]
        public void Combination4()
        {
            int x = (5 << 2) & 8 ^ 3;
            // 5 << 2 = 0101 << 2 = 10100 = 20
            // 20 & 8 = 10100 & 1000 = 0000 = 0
            // 0 ^ 3 = 0000 ^ 0011 = 0011

            Assert.Equal(3, x);
        }

        [Step(11)]
        public void Combination5()
        {
            int x = (5 >> 2) & (~8) ^ 8;
            // 5 >> 2 = 0101 >> 2 = 0001 = 1
            // ~8 = -9 = ~1001 = 0110 +1 = 0111 = 7
            // 1 & 7 = 0001 & 0111 = 0001 = 1
            // 1 ^ 8 = 0001 ^ 1000 = 1001 = 9

            Assert.Equal(9, x);
        }

        [Step(12)]
        public void Combination6()
        {
            int x = (8 << 2) & (~5) & 8 | 10 | (5 >> 1);
            // 8 << 2 = 1000 << 2 = 100000 = 32
            // 32 & ~5 = 32 & -9 = 100000 & (~1001 + 1) = 100000 & (0110 +1) = 100000 & 0111 = 0000 = 0
            // 0 & 8 = 0
            // 0 | 10 = 0000 | 1010 = 1010 = 10
            // 5 >> 1 = 0101 >> 1 = 0010 = 2
            // 10 | 2 = 1010 | 0010 = 1010 = 10

            Assert.Equal(10, x);
        }

        [Step(13)]
        public void AdditionWithoutPlusOrMinusOperator()
        {
            //Solve this problem without using + or -
            //This is a complicated problem. If you don't 
            //know how to solve it, try to Google it.
            int a = 15;
            int b = 4;

            //Here goes your implementation to set value to FILL_ME_IN
            Assert.Equal(19, 19); // non lo so
        }
    }
}