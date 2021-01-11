using System;

namespace _01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRobot myRobot = new MyRobot();
            myRobot.OnFalar += Saudacao;
            myRobot.OnFalar += Speak;

            myRobot.Falar("Olá, i'm Robot");
        }

        static void Saudacao(object sender, RobotEventArgs args)
        {
            Console.WriteLine($"Saudação - {args.Fala}");
        }
        static void Speak(object sender, RobotEventArgs args)
        {
            Console.WriteLine($"Speak - {args.Fala}");
        }
    }
}
