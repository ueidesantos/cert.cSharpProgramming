using System;

namespace _01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRobot myRobot = new MyRobot();
            myRobot.OnFalar += Speak;

            myRobot.Falar("Olá, eu sou um robô!");
        }

        static void Speak(object sender, RobotEventArgs args)
        {
            Console.WriteLine(args.Fala);
            string inputText;
            do
            {
                inputText = Console.ReadLine();
                Console.WriteLine(inputText);
            } while (inputText != "-");
        }
    }
}
