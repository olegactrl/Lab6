using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Car : Vehicle
    {
        public string Type { get; set; }

        public override void Move()
        {
            Console.WriteLine(Speed + " - car speed");
        }
    }
}
