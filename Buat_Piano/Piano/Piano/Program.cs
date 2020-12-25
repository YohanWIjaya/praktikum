using System;
using System.Media;

namespace Piano
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input Berapa Oktaf : ");
            int p = 1000;
            int o = 1; //banyak oktaf
         
            Console.Write(" ");// spasi awal
         
            for (int i = 0; i < (7 * o); i++)//baris pertama
            {
                Console.Write("____");
            }
            Console.Write("___");
            Console.WriteLine();
            tutshitam(o);
            Console.Write("|");
            tutsbawahhitam(o);
            tutspalingbawah(o, p);

            int[] putih = { 262, 294, 330, 349, 392, 440, 494, 523, 542 };
            int[] hitam = { 277, 311, 370, 415, 466 };
            int duration = 700;

            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A://c
                        Console.Beep(putih[1], duration);
                        break;
                    case ConsoleKey.S://d":?
                        Console.Beep(putih[2], duration);
                        break;
                    case ConsoleKey.D://e
                        Console.Beep(putih[3], duration);
                        break;
                    case ConsoleKey.F://f
                        Console.Beep(putih[4], duration);
                        break;
                    case ConsoleKey.G://g
                        Console.Beep(putih[5], duration);
                        break;
                    case ConsoleKey.H://a
                        Console.Beep(putih[6], duration);
                        break;
                    case ConsoleKey.J://b
                        Console.Beep(putih[7], duration);
                        break;
                    case ConsoleKey.K://a
                        Console.Beep(putih[8], duration);
                        break;
                    case ConsoleKey.W://c#
                        Console.Beep(hitam[1], duration);
                        break;
                    case ConsoleKey.E://d#
                        Console.Beep(hitam[2], duration);
                        break;
                    case ConsoleKey.T://f#
                        Console.Beep(hitam[3], duration);
                        break;
                    case ConsoleKey.Y://a#
                        Console.Beep(hitam[4], duration);
                        break;
                    case ConsoleKey.U://b#
                        Console.Beep(hitam[5], duration);
                        break;
                }


            }
        }

        static void tutshitam(int a1)
        {
            for (int i = 0; i < 4; i++) //Tuts Hitam
            {
                Console.Write("|");
                for (int k = 0; k < a1; k++)
                {
                    for (int j = 0; j < (15 * 2); j++)
                    {
                        if (j != 0 && j % 2 == 0 && j != 10 && j != 12 && j != 26 || j == 11 || j == 27)
                        {
                            if (j != 28)
                            {
                                Console.Write("|");
                            }
                        }

                        else //if (j == 0 || j == 1 || j == 3 || j == 5 || j == 7 || j == 9 || j == 10 || j == 12 || j == 13 || j == 15 || j == 17 || j == 19)
                        {
                           
                            if (k > 0 && j == 0)
                            {
                                Console.Write("");
                            }
                            else
                            {

                                Console.Write(" ");
                            }
                        }
                    }
                }
                Console.Write("  |");
                Console.WriteLine();
            }
        }

        static void tutsbawahhitam(int a1)
        {
            for (int k = 0; k < a1; k++)
            {
                for (int j = 0; j < (15 * 2); j++)
                {
                    if (j != 0 && j % 2 == 0 && j != 10 && j != 12 && j != 26 || j == 11 || j == 27)
                    {
                        if (j != 28)
                        {
                            Console.Write("|");
                        }
                    }
                    else //if (j == 0 || j == 1 || j == 3 || j == 5 || j == 7 || j == 9 || j == 10 || j == 12 || j == 13 || j == 15 || j == 17 || j == 19)*/*/*/
                    {
                        if (k > 0 && j == 0)
                        {

                            Console.Write("");
                        }
                        else if (j % 2 == 0 || j == 1 || j == 5 || j == 9 || j == 13 || j == 17 || j == 21 || j == 25 || j == 27 || j == 29)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("_");
                        }
                    }
                }
            }
            Console.Write("  |");
            Console.WriteLine();
        }

        static void tutspalingbawah(int o, int y)
        {
            char no = 'C';
            for (int i = 0; i < 4; i++)
            {
                Console.Write("|");
                for (int j = 0; j < (7 * o) + 1; j++)
                {
                    if (i == 3)// tampilan note
                    {
                        if (y == j)
                        {
                            Console.Write(" " + " " + " |");
                        }
                        else
                        {
                            Console.Write(" " + no + " |");
                        }
                        no++;
                        if (no == 'H')
                        {
                            no = 'A';
                        }
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("|");
            for (int i = 0; i < (7 * o) + 1; i++)
            {
                if (i != (7 * o))
                {
                    Console.Write("___|");
                }
                else
                {
                    Console.Write("___");
                }
            }
            Console.Write("|");
        }

    }
}
