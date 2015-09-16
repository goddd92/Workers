using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    abstract public class parentWorker
    {
        abstract public double avgPayMonth();
    }

    public class hourPayWorker: parentWorker
    {
        private double payment;

        public hourPayWorker()
        {

        }
        public override double avgPayMonth()
        {
            return 20.8 * 8 * payment;
        }
    }

    class fixPayWorker: parentWorker
    {
        public fixPayWorker()
        {

        }
        public override double avgPayMonth()
        {
            return 0;
        }
    }
}
