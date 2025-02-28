using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Calculator
{
    internal class Time_to_Date
    {
        private int day;
        private int month;
        private int year;
        private int hours;
        private int minutes;
        private int seconds;
        private int uDay;
        private int uMonth;
        private int uHours;
        private int uMinutes;
        private int uSeconds;

        public Time_to_Date(int day, int month, int year, int hours, int minutes, int seconds) 
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public void Calculate() 
        {
            do
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
                    day++;
                    hours -= 24;
                }
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        {
                            while (day >= 31)
                            {
                                month++;
                                day -= 31;
                            }
                            break;
                        }
                    case 2:
                        {
                            while (day >= 28)
                            {
                                month++;
                                day -= 28;
                            }
                            break;
                        }
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        {
                            while (day >= 30)
                            {
                                month++;
                                day -= 30;
                            }
                            break;
                        }
                }
                while (month >= 12)
                {
                    year++;
                    month -= 11;
                }
                while (day >= 10)
                {
                    uDay++;
                    day -= 10;
                }
                while (month >= 10)
                {
                    uMonth++;
                    month -= 10;
                }
                while (hours >= 10)
                {
                    uHours++;
                    hours -= 10;
                }
                while (minutes >= 10)
                {
                    uMinutes++;
                    minutes -= 10;
                }
                while (seconds >= 10)
                {
                    uSeconds++;
                    seconds -= 10;
                }
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        {
                            while (uDay >= 3)
                            {
                                month++;
                                uDay -= 3;
                            }
                            break;
                        }
                    case 2:
                        {
                            while (uDay >= 2)
                            {
                                month++;
                                uDay -= 2;
                            }
                            break;
                        }
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        {
                            while (uDay >= 3)
                            {
                                month++;
                                uDay -= 3;
                            }
                            break;
                        }
                }
            } while (day >= 10 || month >= 10 || hours >= 10 || minutes >= 10 || seconds >= 10);
            Console.Clear();
            Console.WriteLine("The date will be: \n {0}{1}/{2}{3}/{4} {5}{6}:{7}{8}:{9}{10} \n", uDay, day, uMonth, month, year, uHours, hours, uMinutes, minutes, uSeconds, seconds);
        }
    }
}
