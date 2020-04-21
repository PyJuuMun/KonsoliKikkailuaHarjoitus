using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

namespace KonsoliKikkailuaHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            string toprint = "Tämä on tekstiä";
            int speed = 0; //60 = 60 millisekunttia
            int y = 0;
            int x = 0;

            List<string> printable = new List<string>();

            //kirjoittaa ensimmäisen kirjaimen
            //Console.Write(toprint[0]);

            Console.WriteLine("Fill what you want to write.");
            toprint = Console.ReadLine();
            Console.WriteLine("Fill in Y coordinate value.");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fill in X coordinate value.");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fill in the printing speed.");
            speed = Convert.ToInt32(Console.ReadLine());
  
            Console.Clear();

            void Printslow(string toprint, int x, int y)
            {
                //asettaa mistä krijoitus alkaa
                Console.SetCursorPosition( y, x);

                //kirjoittaa toprint stringing hitaasti
                for (int i = 0; i < toprint.Length; i++)
                {
                    Console.Write(toprint[i]);
                    //hidastaa koodin kirjoitus nopeuden speed valuen mukaan
                    System.Threading.Thread.Sleep(speed);
                }
            }

            //Printslow(toprint, y, x);
            
            void Method(List<string> printable, int x, int y)
            {
                for (int i = 0; i < 5; i++)
                {
                    printable.Add(toprint);

                    for (int c = 1; c <= 1; c++)
                    {
                        Printslow(toprint, y, x);                        
                    }
                    y += 1;
                }
                               
            }

            Method(printable, x, y);
        }
    }
}
