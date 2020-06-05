
using System;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("mario");
            Mario mario = new Mario();
            mario.Correr();
            mario.Pular();


            System.Console.WriteLine("Luigi");
            Luigi luigi = new Luigi();
            luigi.Pular();
            luigi.Correr();
           
            System.Console.WriteLine("Princesa");
            Princesa princesa = new Princesa();
            princesa.Correr();
            princesa.Pular();
            princesa.Planar();

        }
    }
}
