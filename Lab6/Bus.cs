using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Bus : Vehicle
    {
        public int Seats { get; set; }

        public override void Move()
        {
            Console.WriteLine(Speed + " - bus speed");
        }
    }
}
