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
        protected string name;
        protected int id;
        protected double payment;
    }

    public class hourPayWorker: parentWorker
    {

        public hourPayWorker(string nameW, int idW, double payW)
        {
            name = nameW;
            id = idW;
            payment = payW;
        }

        public override double avgPayMonth()
        {
            return 20.8 * 8 * payment;
        }
    }

    public class fixPayWorker: parentWorker
    {

        public fixPayWorker(string nameW, int idW, double payW)
        {
            name = nameW;
            id = idW;
            payment = payW;
        }

        public override double avgPayMonth()
        {
            return payment;
        }
    }
}
