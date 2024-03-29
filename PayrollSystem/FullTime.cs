﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class FullTime : Employee
    {
        private double salary;
        private double overtime;

        public FullTime(int id, String name, double sal,
                            double hourAndHalf, Vehicle vehicle) : base (id, name, vehicle)
        {
     
            this.overtime = hourAndHalf;
            this.salary = sal;
        }

       
         public override double calulatePay()
        {

            Console.WriteLine("Full time Employee.");
            return (this.getSalary() + this.getOvertime());

        }

        /**
         * @return the salary
         */
        public double getSalary()
        {
            return salary;
        }

        /**
         * @param salary the salary to set
         */
        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        /**
         * @return the overtime
         */
        public double getOvertime()
        {
            return overtime;
        }

        /**
         * @param overtime the overtime to set
         */
        public void setOvertime(double overtime)
        {
            this.overtime = overtime;
        }
    }
}
