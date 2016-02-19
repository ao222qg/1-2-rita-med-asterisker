using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // for-satsen för att bestämma antalet rader.
            for (int row = 0; row < 25; row++)
            {
                
                // Switch-satsen med hjälp av modelus bestämmer vilken rad som ska ha vilken färg.
                    
                    
                // If skapar ett tomrum i början av varje rad.
                    if (row % 2 == 1)
                    {
                        Console.Write(" ");

                    }
                // For skriver ut en asterisk i följd av ett tomrum på varje kolumn.
                    for (int col = 0; col < 39; col++) 
                    {
                        switch (row % 3)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                        }
                        Console.Write("* ");
                    }
                    Console.WriteLine();
            }
           
            Console.ResetColor();
        }
    }
}
