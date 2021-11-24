using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class PartTime : Employee
    {
        private double rate;
        private double hoursWorked;

        public PartTime(int id, String name, double rate,
                            double hoursWorked2, Vehicle v1) : base (id, name, v1)
        {
            this.rate = rate;
            this.hoursWorked = hoursWorked2;
        }

        public override double calculatePay()
        {

            Console.WriteLine("Part time Employee.");
            return (this.getHoursWorked() * this.getRate());
        }

        /**
         * @return the rate
         */
        public double getRate()
        {
            return rate;
        }

        /**
         * @param rate the rate to set
         */
        public void setRate(double rate)
        {
            this.rate = rate;
        }

        /**
         * @return the hoursWorked
         */
        public double getHoursWorked()
        {
            return hoursWorked;
        }

        /**
         * @param hoursWorked the hoursWorked to set
         */
        public void setHoursWorked(double hoursWorked)
        {
            this.hoursWorked = hoursWorked;
        }
    }
}
