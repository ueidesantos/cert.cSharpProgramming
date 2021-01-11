using System;
using System.Collections.Generic;
using System.Text;

namespace _01_01
{
    public class RobotEventArgs : EventArgs
    {
        public string Fala { get; }

        public RobotEventArgs(string fala)
        {
            Fala = fala;
        }

    }
}
