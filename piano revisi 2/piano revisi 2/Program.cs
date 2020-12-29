using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp93
{
    class Program
    {
        static void Main(string[] args)
        {



            string title = @"

██████╗░░█████╗░██╗░░██╗██╗████████╗  ██████╗░░█████╗░  ██████╗░██╗░█████╗░███╗░░██╗░█████╗░
██╔══██╗██╔══██╗██║░██╔╝██║╚══██╔══╝  ██╔══██╗██╔══██╗  ██╔══██╗██║██╔══██╗████╗░██║██╔══██╗
██████╔╝███████║█████═╝░██║░░░██║░░░  ██████╔╝██║░░╚═╝  ██████╔╝██║███████║██╔██╗██║██║░░██║
██╔══██╗██╔══██║██╔═██╗░██║░░░██║░░░  ██╔═══╝░██║░░██╗  ██╔═══╝░██║██╔══██║██║╚████║██║░░██║
██║░░██║██║░░██║██║░╚██╗██║░░░██║░░░  ██║░░░░░╚█████╔╝  ██║░░░░░██║██║░░██║██║░╚███║╚█████╔╝
╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░╚═╝░░░  ╚═╝░░░░░░╚════╝░  ╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░
                           ____________________________________
                          |\                                    \
                          | \                                    \
                          |  \____________________________________\
                          |  |       __---_ _---__                |
                          |  |      |======|=====|                |
                          |  |      |======|=====|                |
                          |  |  ____|__---_|_---_|______________  |
                          |  | |                                | |
                          |   \ \                                \ \
                          |  \ ||\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\| |     
                          |  |\  ,--------------------------------  |
                          |  ||| |                               || |
                           \ ||| |           -  -                || |
                            \'|| |-----------\\-\\---------------|| |
                             \||_|                             \|_|_|




                                                                 ";

            Console.WriteLine(title);
            Console.WriteLine("                       ===============PIANO BY RAKIT PC===============");
            Console.WriteLine(" ");
            Console.WriteLine("1. PLAY PIANO ");
            Console.WriteLine("2. PLAY MUSIC ");
            Console.WriteLine("3. QUIT       ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("Silahkan input = ");
            int menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                piano();
            }
            Console.Clear();

            if (menu == 2)
            {
                music();
            }
            Console.Clear();

            if (menu == 3)
            {
                exit();
            }
            Console.Clear();


        }

        static void piano()
        {

            Console.Clear();
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

        static void music()
        {
            Console.Clear();
            Console.WriteLine("SILAHKAN PILIH");
            Console.WriteLine("1. HAPPY BIRTDAY ");
            Console.WriteLine("2. SUPER MARIO ");
            Console.WriteLine("3. TETRIS      ");
            Console.WriteLine(" ");
            Console.Write("SILAHKAN INPUT =  ");
            int music = Convert.ToInt32(Console.ReadLine());

            if (music == 1)
            {

                string hbd = @"


   ___________________§§§§§§
_____________§§§§__§§__§§_§§§§§§
_____§§__§§_§§__§§_§§§§§§_§§__§§_§§____§§
_____§§__§§_§§§§§§_§§_____§§§§§§__§§__§§
_____§§§§§§_§§__§§_§§_____§§_______§§§§
_____§§__§§_§§__§§________§§________§§
_____§§__§§_________________________§§

_______§§§§§§___§§__§§§§§__§§§§§§_§§__§§
_______§§___§§__§§__§§__§§___§§___§§__§§
_______§§§§§§___§§__§§§§§____§§___§§§§§§
_______§§___§§__§§__§§_§§____§§___§§__§§
_______§§§§§§___§§__§§__§§___§§___§§__§§

__________§§§§§§§__________§§____§§
___________§§___§§___§§§§§__§§__§§
___________§§___§§__§§___§§__§§§§
___________§§___§§__§§§§§§§___§§
__________§§§§§§§___§§___§§___§§
____________________§§___§§
________________¶¶
_______________¶¶¶¶_______________¶¶
______________¶¶S¶¶______¶¶_____¶¶¶¶
_____________¶¶SS¶_____¶¶¶¶____¶¶SS¶
_____________¶¶S¶¶____¶¶SS¶___¶¶SS¶¶
______________¶¶______¶SS¶_____¶SS¶
_____________¶¶¶¶¶_____¶¶_______¶¶
_____________¶__¶¶____¶¶¶¶¶____¶¶¶¶¶
_____________¶__¶¶____¶__¶¶____¶__¶¶
_____________¶__¶_____¶__¶¶____¶__¶¶
_____________¶__¶_____¶__¶¶____¶__¶
_____________¶__¶_____¶__¶_____¶__¶
___________¶¶¶__¶¶¶¶¶¶¶__¶¶¶¶¶¶¶__¶
________¶¶¶¶¶¶__¶11111¶__¶11111¶__¶¶¶¶
______¶¶¶1111¶__¶11111¶__¶11111¶__¶11¶¶¶¶
_____¶¶111$11¶¶¶¶11111¶__¶11111¶¶¶¶11$11¶¶¶
____¶¶111$$$$11111$111¶¶¶¶11$1111111$$$$11¶¶
____¶¶¶¶111$11111$$$$111111$$$$1111111$11¶¶¶
____¶__¶¶¶¶¶¶¶¶1111$111111111$1111111¶¶¶¶¶_¶
___¶¶______¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶____¶¶¶
_¶¶¶¶_____§§________________________§§__¶¶11¶¶
¶¶11¶¶__§§_§§___§§_____§§____§§___§§_§§_¶¶111¶
¶111¶¶¶___§§___§§_§§__§§_§§_§§_§§___§§_¶¶¶111¶
¶1111¶¶¶¶________§§_____§§____§§_____¶¶¶¶111¶¶
¶¶¶¶111¶¶¶¶¶¶¶¶¶¶¶________¶¶¶¶¶¶¶¶¶¶¶¶¶¶11¶¶¶¶
__¶¶¶¶¶11111111¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶11111111¶¶¶
____¶¶¶11111111111111111111111111111111111¶¶
_____¶¶¶¶111¶¶¶¶11111111¶¶11111111¶¶¶¶1111¶¶
______¶¶¶¶¶¶¶¶¶¶¶111¶¶¶¶¶¶¶1111¶¶¶_¶¶¶¶¶¶¶
_______________¶¶¶¶¶¶¶¶___¶¶¶¶¶¶¶¶







                                       ";

                Console.WriteLine(hbd);

                Thread.Sleep(2000);
                Console.Beep(264, 125);
                Thread.Sleep(250);
                Console.Beep(264, 125);
                Thread.Sleep(125);
                Console.Beep(297, 500);
                Thread.Sleep(125);
                Console.Beep(264, 500);
                Thread.Sleep(125);
                Console.Beep(352, 500);
                Thread.Sleep(125);
                Console.Beep(330, 1000);
                Thread.Sleep(250);
                Console.Beep(264, 125);
                Thread.Sleep(250);
                Console.Beep(264, 125);
                Thread.Sleep(125);
                Console.Beep(297, 500);
                Thread.Sleep(125);
                Console.Beep(264, 500);
                Thread.Sleep(125);
                Console.Beep(396, 500);
                Thread.Sleep(125);
                Console.Beep(352, 800);
                Thread.Sleep(250);
                Console.Beep(264, 125);
                Thread.Sleep(250);
                Console.Beep(264, 125);
                Thread.Sleep(125);
                Console.Beep(264, 500);
                Thread.Sleep(125);
                Console.Beep(440, 500);
                Thread.Sleep(125);
                Console.Beep(352, 250);
                Thread.Sleep(125);
                Console.Beep(352, 125);
                Thread.Sleep(125);
                Console.Beep(330, 500);
                Thread.Sleep(125);
                Console.Beep(297, 1000);
                Thread.Sleep(250);
                Console.Beep(466, 125);
                Thread.Sleep(250);
                Console.Beep(466, 125);
                Thread.Sleep(125);
                Console.Beep(440, 500);
                Thread.Sleep(125);
                Console.Beep(352, 500);
                Thread.Sleep(125);
                Console.Beep(396, 500);
                Thread.Sleep(125);
                Console.Beep(352, 1000);

            }

            if (music == 2)
            {
                string mario = @"

                               ███████  ███████
          ████▓▓▓▓▓▓████░░░░░██
        ██▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░██
       ██▓▓▓▓▓▓████████████░░░░██
     ██▓▓▓▓▓▓████████████████░██
    ██▓▓████░░░░░░░░░░░░██████
  ████████░░░░░░██░░██░░██▓▓▓▓██              ███╗░░░███╗░█████╗░██████╗░██╗░█████╗░
 ██░░████░░░░░░██░░██░░██▓▓▓▓██               ████╗░████║██╔══██╗██╔══██╗██║██╔══██╗
██░░░░██████░░░░░░░░░░░░░░██▓▓██              ██╔████╔██║███████║██████╔╝██║██║░░██║
██░░░░░░██░░░░██░░░░░░░░░░██▓▓██              ██║╚██╔╝██║██╔══██║██╔══██╗██║██║░░██║
  ██░░░░░░░░░███████░░░░██████                ██║░╚═╝░██║██║░░██║██║░░██║██║╚█████╔╝
    ████░░░░░░░███████████▓▓██                ╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░╚════╝░
     ██████░░░░░░░░░░██▓▓▓▓██
   ██▓▓▓▓██████████████▓▓██
 ██▓▓▓▓▓▓▓▓████░░░░░░████
████▓▓▓▓▓▓▓▓██░░░░░░░░░░██
████▓▓▓▓▓▓▓▓██░░░░░░░░░░██                   
██████▓▓▓▓▓▓▓▓██░░░░░░████████
 ██████▓▓▓▓▓▓████████████████
    █████████████████████▓▓▓▓██
  ██▓▓▓▓████████████████▓▓▓▓▓▓██
████▓▓██████████████████▓▓▓▓▓▓██
██▓▓▓▓██████████████████▓▓▓▓▓▓██
██▓▓▓▓██████████     ██▓▓▓▓████
██▓▓▓▓████              ██████ 
  ████



                                                     ";
                Console.WriteLine(mario);
                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);

            }

            if (music == 3)
            {

                string tetris = @"


             ███████████████████████████████████████████████████████████████████████████████████████████
             █░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░░███░░░░░░░░░░█░░░░░░░░░░░░░░█
             █░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀▄▀░░███░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█
             █░░░░░░▄▀░░░░░░█░░▄▀░░░░░░░░░░█░░░░░░▄▀░░░░░░█░░▄▀░░░░░░░░▄▀░░███░░░░▄▀░░░░█░░▄▀░░░░░░░░░░█
             █████░░▄▀░░█████░░▄▀░░█████████████░░▄▀░░█████░░▄▀░░████░░▄▀░░█████░░▄▀░░███░░▄▀░░█████████
             █████░░▄▀░░█████░░▄▀░░░░░░░░░░█████░░▄▀░░█████░░▄▀░░░░░░░░▄▀░░█████░░▄▀░░███░░▄▀░░░░░░░░░░█
             █████░░▄▀░░█████░░▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀░░█████░░▄▀▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀░░███░░▄▀▄▀▄▀▄▀▄▀░░█
             █████░░▄▀░░█████░░▄▀░░░░░░░░░░█████░░▄▀░░█████░░▄▀░░░░░░▄▀░░░░█████░░▄▀░░███░░░░░░░░░░▄▀░░█
             █████░░▄▀░░█████░░▄▀░░█████████████░░▄▀░░█████░░▄▀░░██░░▄▀░░███████░░▄▀░░███████████░░▄▀░░█
             █████░░▄▀░░█████░░▄▀░░░░░░░░░░█████░░▄▀░░█████░░▄▀░░██░░▄▀░░░░░░█░░░░▄▀░░░░█░░░░░░░░░░▄▀░░█
             █████░░▄▀░░█████░░▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀░░█████░░▄▀░░██░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█
             █████░░░░░░█████░░░░░░░░░░░░░░█████░░░░░░█████░░░░░░██░░░░░░░░░░█░░░░░░░░░░█░░░░░░░░░░░░░░█ 
             ███████████████████████████████████████████████████████████████████████████████████████████

                


                                  
                                                         ";

                Console.WriteLine(tetris);


                Console.Beep(1320, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125); Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); System.Threading.Thread.Sleep(250); Console.Beep(1188, 500); Console.Beep(1408, 250); Console.Beep(1760, 500); Console.Beep(1584, 250); Console.Beep(1408, 250); Console.Beep(1320, 750); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); System.Threading.Thread.Sleep(500); ;

            }


        }


        static void exit()
        {


            string thanks = @"


────────────────────▄▄▄▄
────────────────▄▄█▀▀──▀▀█▄
─────────────▄█▀▀─────────▀▀█▄
────────────▄█▀──▄▄▄▄▄▄──────▀█
────────────█───█▌────▀▀█▄─────█
────────────█──▄█────────▀▀▀█──█
────────────█──█──▀▀▀──▀▀▀▄─▐──█
────────────█──▌────────────▐──█
────────────█──▌─▄▀▀▄───────▐──█
───────────█▀▌█──▄▄▄───▄▀▀▄─▐──█
───────────▌─▀───█▄█▌─▄▄▄────█─█
───────────▌──────▀▀──█▄█▌────█
───────────█───────────▀▀─────▐
────────────█──────▌──────────█
────────────██────█──────────█
─────────────█──▄──█▄█─▄────█
─────────────█──▌─▄▄▄▄▄─█──█
─────────────█─────▄▄──▄▀─█
─────────────█▄──────────█
─────────────█▀█▄▄──▄▄▄▄▄█▄▄▄▄▄
───────────▄██▄──▀▀▀█─────────█
──────────██▄─█▄────█─────────█
───▄▄▄▄███──█▄─█▄───█─────────██▄▄▄
▄█▀▀────█────█──█▄──█▓▓▓▓▓▓▓▓▓█───▀▀▄
█──────█─────█───████▓▓▓▓▓▓▓▓▓█────▀█
█──────█─────█───█████▓▓▓▓▓▓▓█──────█
█─────█──────█───███▀▀▀▀█▓▓▓█───────█
█────█───────█───█───▄▄▄▄████───────█
█────█───────█──▄▀───────────█──▄───█
█────█───────█─▄▀─────█████▀▀▀─▄█───█
█────█───────█▄▀────────█─█────█────█
█────█───────█▀───────███─█────█────█
█─────█────▄█▀──────────█─█────█────█
█─────█──▄██▀────────▄▀██─█▄───█────█
█────▄███▀─█───────▄█─▄█───█▄──█────█
█─▄██▀──█──█─────▄███─█─────█──█────█
██▀────▄█───█▄▄▄█████─▀▀▀▀█▀▀──█────█
█──────█────▄▀──█████─────█────▀█───█
───────█──▄█▀───█████─────█─────█───█
──────▄███▀─────▀███▀─────█─────█───█
─────────────────────────────────────
 ▀█▀ █░█ ▄▀█ █▄░█ █▄▀   █▄█ █▀█ █░█
 ░█░ █▀█ █▀█ █░▀█ █░█   ░█░ █▄█ █▄█


                                    ";

            Console.WriteLine(thanks);

            Console.ReadKey();



        }


    }

}