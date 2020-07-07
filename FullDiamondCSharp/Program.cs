using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDiamondCSharp
{
    class Program
    {
        static void Main(string[] args)
        {                       
            FullDiamond(15, '*');
            Console.ReadLine();
        }
        static void FullDiamond(int length, char chr)
        {
            if (IsEven(length)) return;
            char space = ' ';            
            if (length >= 3)
            {
                for (int i = 1; i <= length ; i++)
                {
                    Console.WriteLine(i == 1 ? new string(space, length - i) + new string(chr, 1) : new string(space, length - i) + new string(chr, 1) + new string(chr, i -1) + new string(space, i - 2) + new string(chr, 1));                   
                }
                for (int i = length-1; i >= 1; i--)
                {
                    Console.WriteLine(i == 1 ? new string(space, length - i) + new string(chr, 1) : new string(space, length - i) + new string(chr, 1) + new string(chr, i - 1) + new string(space, i - 2) + new string(chr, 1));
                }
            }
        }        
        static bool IsEven(int value) // method to check odd or even number return with true or false
        {
            if (value % 2 == 0) return true;            
            return false;
        }
        
        
    }
}
