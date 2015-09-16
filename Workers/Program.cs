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
            var stuff = new Employee[]
            {
                new PartTime ("Stuart", 10),
                new PartTime ("Stenley", 12),
                new PartTime ("Monkey", 19),
                new PartTime ("Abibas", 9),
                new FullTime ("Marty", 2100),
                new FullTime ("Mary", 3000),
                new FullTime ("Vampire", 2500),
                new FullTime ("Lolz", 5500),
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

    abstract public class Employee : IComparable
    {
        protected string name;
        static protected int id = 0;
        protected double payment;

        public Employee(string name, double payment)
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

    public class PartTime: Employee
    {

        public PartTime(string name, double payment) : base(name, payment)
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

    public class FullTime: Employee
    {

        public FullTime(string name, double payment) : base (name, payment)
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
