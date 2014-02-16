using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            this.iranyX = rnd.Next(0, 80);
            this.iranyY = rnd.Next(0, 25);
            Console.SetCursorPosition(helyX, helyY);
            Console.Write("O");

        }

        public void Mozog() {
            while (true) {
                if (iranyX < helyX && iranyY < helyY) {
                    Console.Write(" ");
                    Console.SetCursorPosition(helyX - 1, helyY - 1);
                    Console.Write("O");
                }
                else if (iranyX < helyX && iranyY > helyY) {
                    Console.Write(" ");
                    Console.SetCursorPosition(helyX - 1, helyY + 1);
                    Console.Write("O");
                }
                else if (iranyX > helyX && iranyY < helyY) {
                    Console.Write(" ");
                    Console.SetCursorPosition(helyX + 1, helyY - 1);
                    Console.Write("O");
                }
                else if (iranyX > helyX && iranyY > helyY) {
                    Console.Write(" ");
                    Console.SetCursorPosition(helyX + 1, helyY + 1);
                    Console.Write("O");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args) {

            PattogosLabda labda = new PattogosLabda();
            labda.Mozog();
            Console.ReadKey();
        }
    }
}
