using System;
using System.Collections.Generic;
using System.Text;

namespace _01_01
{
    public class MyRobot
    {
        public event EventHandler<RobotEventArgs> OnFalar;

        public void Falar(string fala)
        {
            foreach (var manipulador in OnFalar.GetInvocationList())
            {
                manipulador.DynamicInvoke(this, new RobotEventArgs(fala));
                Console.WriteLine("********************************************************");
            }


        }
    }
}
