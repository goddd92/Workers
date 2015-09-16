﻿using System;
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


            foreach(var element in stuff)
            {

                data += element.GetID().ToString() + " " + element.GetName() + " " + element.AvgPayMonth()  + " \n";

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

    abstract public class Employee : IComparable<Employee>
    {
        protected string name;
        static protected int id;
        protected double payment;

        public Employee(string name, double payment)
        {
            this.name = name;
            id++;
            this.payment = payment;

        }

        abstract public double AvgPayMonth();
        abstract public int GetID();
        abstract public string GetName();

        public int CompareTo(Employee other)
        {
            if (this.payment == other.payment)
                return this.name.CompareTo(other.name);
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
}
