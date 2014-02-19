using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace PattogosLabda
{
    class PattogosLabda
    {
        int helyX;
        int helyY;
        int iranyX;
        int iranyY;
        Random rnd = new Random();
        ConsoleColor szin;

        public PattogosLabda(ConsoleColor szin, int pozX, int pozY) {
            this.helyX = pozX;
            this.helyY = pozY;
            this.iranyX = -1;
            this.iranyY = -1;
            this.szin = szin;
        }

        public void Mozog() {
            while (true) {   
                lock(typeof(Program)){
                Console.SetCursorPosition(helyX, helyY);
                Console.Write(' ');
                }
                if (helyX < 80 && helyX > 0 && helyY < 25 && helyY > 0) {
                    helyX += iranyX;
                    helyY += iranyY;
                }
                if (helyX == 0 || helyX == 80) {
                    iranyX *= -1;
                    helyX += iranyX;
                }
                if (helyY == 0 || helyY == 25) {
                    iranyY *= -1;
                    helyY += iranyY;
                }
                lock (typeof(Program)) {
                    Console.SetCursorPosition(helyX, helyY);
                    Console.ForegroundColor = szin;
                    Console.WriteLine("O");
                }
                    Thread.Sleep(100);
                
            }
        }
    }

    class Program
    {
        static void Main(string[] args) {

            PattogosLabda labda1 = new PattogosLabda(ConsoleColor.Blue, 2, 14);
            PattogosLabda labda2 = new PattogosLabda(ConsoleColor.Green, 3, 7);
            PattogosLabda labda3 = new PattogosLabda(ConsoleColor.Yellow, 40, 8);
            PattogosLabda labda4 = new PattogosLabda(ConsoleColor.White, 24, 12);
            PattogosLabda labda5 = new PattogosLabda(ConsoleColor.Red, 70, 2);
            PattogosLabda labda6 = new PattogosLabda(ConsoleColor.DarkMagenta, 35, 0);
            Thread szal1 = new Thread(labda1.Mozog);
            Thread szal2 = new Thread(labda2.Mozog);
            Thread szal3 = new Thread(labda3.Mozog);
            Thread szal4 = new Thread(labda4.Mozog);
            Thread szal5 = new Thread(labda5.Mozog);
            Thread szal6 = new Thread(labda6.Mozog);

            szal1.Start();
            szal2.Start();
            szal3.Start();
            szal4.Start();
            szal5.Start();
            szal6.Start();
            /*
            szal1.Join();
            szal2.Join();
            szal3.Join();
            szal4.Join();
            szal5.Join();
            szal6.Join();*/
            /*labda1.Mozog();
            labda2.Mozog();
            labda3.Mozog();
            labda4.Mozog();
            labda5.Mozog();
            labda6.Mozog();*/
            Console.ReadLine();
        }
    }
}
