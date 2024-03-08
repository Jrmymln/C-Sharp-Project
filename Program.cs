using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    { 
        int DecimalNumber = 56;
        Console.WriteLine("Decimal Integer Literals: " + DecimalNumber);
    
        int BinaryNumber = 0b111000;
        Console.WriteLine("Binary Integer Literals: " + BinaryNumber);
    
        int OctalNumber = 56;
        Console.WriteLine("Octal Integer Literals: " + OctalNumber); 
    
        int HexadecimalNumber = 0x38;
        Console.WriteLine("Hexadecimal Integer Literals: " + HexadecimalNumber);
    
        uint UnsignedintNumber = 56u;
        Console.WriteLine("Unsigned Literals: " + UnsignedintNumber);
    
        long LongvalueNumber = 56L;
        Console.WriteLine("Longvalue Literals: " + LongvalueNumber);
        
        ulong UnsignedlongNumber = 56UL;
        Console.WriteLine("Ulongvalue Literals: " + UnsignedlongNumber);

        if (DecimalNumber == 56 &&
                BinaryNumber == 56 &&
                OctalNumber == 56 &&
                HexadecimalNumber == 56 &&
                UnsignedintNumber == 56 &&
                LongvalueNumber == 56 &&
                UnsignedlongNumber == 56)
                {
                    Console.WriteLine("All representatives are correct");
                }

        else if (DecimalNumber < 56 ||
                    BinaryNumber < 56 ||
                    OctalNumber < 56 ||
                    HexadecimalNumber < 56 ||
                    UnsignedintNumber < 56 ||
                    LongvalueNumber < 56 ||
                    UnsignedlongNumber < 56)
                {
                    Console.WriteLine("All representatives are correct");
                }
                
        else
        {
            Console.WriteLine("All representatives are incorrect");
        }
    }
  }
}