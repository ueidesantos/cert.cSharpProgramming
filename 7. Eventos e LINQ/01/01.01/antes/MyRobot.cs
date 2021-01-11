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
            if (OnFalar != null)
            {
                OnFalar(this, new RobotEventArgs(fala));
                Console.WriteLine("********************************************************");
            }
        }
    }
}
