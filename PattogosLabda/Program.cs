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

        public PattogosLabda() {
            this.helyX = rnd.Next(0, 80);
            this.helyY = rnd.Next(0, 25);
            this.iranyX = -1;
            this.iranyY = -1;
        }

        public void Mozog() {
            while (true) {                
                Console.SetCursorPosition(helyX, helyY);
                Console.Write(' ');
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
                Console.SetCursorPosition(helyX, helyY);
                Console.WriteLine("O");
                Thread.Sleep(100);
            }
        }
    }

    class Program
    {
        static void Main(string[] args) {

            PattogosLabda labda = new PattogosLabda();
            labda.Mozog();
            Console.ReadLine();
        }
    }
}
