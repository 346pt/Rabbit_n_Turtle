using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rabbit_n_Turtle
{
    internal class AnimalThread
    {
        public string name;
        public Thread thread;
        public AnimalThread(string name)
        {
            this.name = name;
        }
    }
}
