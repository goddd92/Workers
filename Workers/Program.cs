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
        protected string name;
        protected int id;
        protected double payment;

        public parentWorker(string name, int id, double payment)
        {
            this.name = name;
            this.id = id;
            this.payment = payment;

        }

        abstract public double avgPayMonth();
    }

    public class hourPayWorker: parentWorker
    {

        public hourPayWorker(string name, int id, double payment) : base(name, id, payment)
        { }

        public override double avgPayMonth()
        {
            return 20.8 * 8 * payment;
        }
    }

    public class fixPayWorker: parentWorker
    {

        public fixPayWorker(string name, int id, double payment) : base (name, id, payment)
        { }

        public override double avgPayMonth()
        {
            return payment;
        }
    }
}
