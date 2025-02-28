using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Calculator
{
    internal class Converter
    {
        private int years;
        private int days;
        private int hours;
        private int minutes;
        private int seconds;

        public Converter(int years, int days, int hours, int minutes, int seconds) { this.years = years; this.days = days; this.hours = hours; this.minutes = minutes; this.seconds = seconds; }

        public void Years() 
        {
            while (seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }
            while (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
            while (hours >= 24)
            {
                days++;
                hours -= 24;
            }
            while (days >= 365)
            {
                years++;
                days -= 365;
            }
            Console.WriteLine(" Years: {0} \n Days: {1} \n Hours: {2} \n Minutes: {3} \n Seconds: {4} \n", years, days, hours, minutes, seconds);
        }
        public void Days() 
        {
            while (years > 0)
            {
                days += 365;
                years--;
            }
            while (seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }
            while (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
            while (hours >= 24)
            {
                days++;
                hours -= 24;
            }
            Console.WriteLine(" Days: {0} \n Hours: {1} \n Minutes: {2} \n Seconds: {3} \n", days, hours, minutes, seconds);
        }
        public void Hours()
        {
            while (seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }
            while (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
            while (years > 0)
            {
                days += 365;
                years--;
            }
            while (days > 0)
            {
                hours += 24;
                days--;
            }
            Console.WriteLine(" Hours: {0} \n Minutes: {1} \n Seconds: {2} \n", hours, minutes, seconds);
        }
        public void Minutes() 
        {
            while (seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }
            while (years > 0)
            {
                days += 365;
                years--;
            }
            while (days > 0)
            {
                hours += 24;
                days--;
            }
            while (hours > 0)
            {
                minutes += 60;
                hours--;
            }
            Console.WriteLine(" Minutes: {0} \n Seconds: {1} \n", minutes, seconds);
        }
        public void Seconds() 
        {
            while (years > 0)
            {
                days += 365;
                years--;
            }
            while (days > 0)
            {
                hours += 24;
                days--;
            }
            while (hours > 0)
            {
                minutes += 60;
                hours--;
            }
            while (minutes > 0)
            {
                seconds += 60;
                minutes--;
            }
            Console.WriteLine(" Seconds: {0} \n", seconds);
        }
    }
}
