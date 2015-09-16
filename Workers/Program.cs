using System;
using System.Collections;
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
            string data = "";

            List<Employee> stuff = new List<Employee>();
            stuff.Add(new PartTime("Stuart", 10));
            stuff.Add(new PartTime("Stenley", 12));
            stuff.Add(new PartTime("Abibas", 9));
            stuff.Add(new PartTime("Monkey", 19));
            stuff.Add(new FullTime("Marty", 2100));
            stuff.Add(new FullTime("Mary", 3000));
            stuff.Add(new FullTime("Vampire", 2500));
            stuff.Add(new FullTime("Lolz", 5500));

            stuff.Sort();

            foreach(var element in stuff)
            {

                data += element.ToString() + " \n";

            }
            Console.Write(data);
            Console.ReadKey();

            System.IO.File.WriteAllText("Emploeye.txt", data);

        }
    }

    public enum EmployType
    {
        PartyTime,
        FullTime
    };

    public abstract class Employee : IComparable<Employee>
    {
        protected string name;
        protected int id;
        protected double payment;

        public Employee(string name, double payment)
        {
            this.name = name;
            id = new Counter().Increment();
            this.payment = payment;

        }

        public abstract double AvgPayMonth();
        public abstract int GetID();
        public abstract string GetName();

        public override string ToString()
        {
            return GetID() + " " + GetName() + " " + AvgPayMonth();
        }

        public int CompareTo(Employee other)
        {
            if (payment == other.payment)
            {
                return this.name.CompareTo(other.name);
            }
            return other.payment.CompareTo(this.payment);
        }
    }

    public class PartTime: Employee
    {

        public PartTime(string name, double payment) : base(name, payment)
        { }

        public override double AvgPayMonth()
        {
            return 20.8 * 8 * payment;
        }
        public override int GetID()
        {
            return id;
        }
        public override string GetName()
        {
            return name;
        }
    }

    public class FullTime: Employee
    {

        public FullTime(string name, double payment) : base (name, payment)
        { }

        public override double AvgPayMonth()
        {
            return payment;
        }
        public override int GetID()
        {
            return id;
        }
        public override string GetName()
        {
            return name;
        }
    }

    public class Counter
    {
        private static int _i;

        public int Increment()
        {
            return _i++;
        }
    }
}
