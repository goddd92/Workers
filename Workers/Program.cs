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
        abstract public int avgPayMonth();
    }

    public class hourPayWorker: parentWorker
    {
        public hourPayWorker()
        {

        }
        public override int avgPayMonth()
        {
            return 0;
        }
    }

    class fixPayWorker: parentWorker
    {
        public fixPayWorker()
        {

        }
        public override int avgPayMonth()
        {
            return 0;
        }
    }
}
