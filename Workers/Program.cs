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
            var stuff = new parentWorker[]
            {
                new hourPayWorker ("Stuart", 10),
                new hourPayWorker ("Stenley", 12),
                new hourPayWorker ("Monkey", 19),
                new hourPayWorker ("Abibas", 9),
                new fixPayWorker ("Marty", 2100),
                new fixPayWorker ("Mary", 3000),
                new fixPayWorker ("Vampire", 2500),
                new fixPayWorker ("Lolz", 5500),
            };

            StringBuilder data = new StringBuilder();
            data.Append();

            System.IO.File.WriteAllLines("C:\\Users\\koshkowskyii\\Documents\\Emploeye.txt", stuff[]);

        }
    }

    public enum EmployType
    {
        hourPay,
        fullTime
    };

    abstract public class parentWorker : IComparable
    {
        protected string name;
        static protected int id = 0;
        protected double payment;

        public parentWorker(string name, double payment)
        {
            this.name = name;
            id++;
            this.payment = payment;

        }

        abstract public double avgPayMonth();
        abstract public int getID();
        abstract public string getName();


        public int CompareTo(object obj)
        {
            return name.CompareTo(obj);
        }
    }

    public class hourPayWorker: parentWorker
    {

        public hourPayWorker(string name, double payment) : base(name, payment)
        { }

        public override double avgPayMonth()
        {
            return 20.8 * 8 * payment;
        }
        public override int getID()
        {
            return id;
        }
        public override string getName()
        {
            return name;
        }
    }

    public class fixPayWorker: parentWorker
    {

        public fixPayWorker(string name, double payment) : base (name, payment)
        { }

        public override double avgPayMonth()
        {
            return payment;
        }
        public override int getID()
        {
            return id;
        }
        public override string getName()
        {
            return name;
        }
    }
}
