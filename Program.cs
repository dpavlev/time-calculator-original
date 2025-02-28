using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Time_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeatFunc = true;
            bool repeatChoser = true; //choser
            DateTime local = DateTime.Now;
            Timer timer = new Timer();
            timer.Interval = 5000;
            do //choser
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Choose function: \n 1) Add to Local Time \n 2) Add Time to a Date \n 3) Add and Convert Time \n\n x) Exit \n\nLocal time: {0}", local.ToString("ddd, dd/MM/yyyy HH:mm:ss"));
                    char key1 = Console.ReadKey().KeyChar;
                    switch (key1)
                    {
                        case 'x': //Exit
                            {
                                Console.Clear();
                                repeatChoser = false;
                                break;
                            }
                        case '3': //Convert TIme 
                            {
                                do 
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Convert time to: \n 1) Years \n 2) Days \n 3) Hours \n 4) Minutes \n 5) Seconds \n\n x) Exit");
                                        char n = Console.ReadKey().KeyChar;
                                        switch (n)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    Console.Write(" Years: ");
                                                    int y = int.Parse(Console.ReadLine());
                                                    Console.Write(" Days: ");
                                                    int d = int.Parse(Console.ReadLine());
                                                    Console.Write(" Hours: ");
                                                    int h = int.Parse(Console.ReadLine());
                                                    Console.Write(" Minutes: ");
                                                    int m = int.Parse(Console.ReadLine());
                                                    Console.Write(" Seconds: ");
                                                    int s = int.Parse(Console.ReadLine());
                                                    Converter objject = new Converter(y, d, h, m, s);
                                                    Console.Clear();
                                                    objject.Years();
                                                    Console.Write("Calculate another time? Y/N ");
                                                    char c = Console.ReadKey().KeyChar;
                                                    if (c == 'n')
                                                    {
                                                        Console.Clear();
                                                        repeatFunc = false;
                                                    }
                                                    break;
                                                }
                                            case '2':
                                                {
                                                    Console.Clear();
                                                    Console.Write(" Years: ");
                                                    int y = int.Parse(Console.ReadLine());
                                                    Console.Write(" Days: ");
                                                    int d = int.Parse(Console.ReadLine());
                                                    Console.Write(" Hours: ");
                                                    int h = int.Parse(Console.ReadLine());
                                                    Console.Write(" Minutes: ");
                                                    int m = int.Parse(Console.ReadLine());
                                                    Console.Write(" Seconds: ");
                                                    int s = int.Parse(Console.ReadLine());
                                                    Converter objject = new Converter(y, d, h, m, s);
                                                    Console.Clear();
                                                    objject.Days();
                                                    Console.Write("Calculate another time? Y/N ");
                                                    char c = Console.ReadKey().KeyChar;
                                                    if (c == 'n')
                                                    {
                                                        Console.Clear();
                                                        repeatFunc = false;
                                                    }
                                                    break;
                                                }
                                            case '3':
                                                {
                                                    Console.Clear();
                                                    Console.Write(" Years: ");
                                                    int y = int.Parse(Console.ReadLine());
                                                    Console.Write(" Days: ");
                                                    int d = int.Parse(Console.ReadLine());
                                                    Console.Write(" Hours: ");
                                                    int h = int.Parse(Console.ReadLine());
                                                    Console.Write(" Minutes: ");
                                                    int m = int.Parse(Console.ReadLine());
                                                    Console.Write(" Seconds: ");
                                                    int s = int.Parse(Console.ReadLine());
                                                    Converter objject = new Converter(y, d, h, m, s);
                                                    Console.Clear();
                                                    objject.Hours();
                                                    Console.Write("Calculate another time? Y/N ");
                                                    char c = Console.ReadKey().KeyChar;
                                                    if (c == 'n')
                                                    {
                                                        Console.Clear();
                                                        repeatFunc = false;
                                                    }
                                                    break;
                                                }
                                            case '4':
                                                {
                                                    Console.Clear();
                                                    Console.Write(" Years: ");
                                                    int y = int.Parse(Console.ReadLine());
                                                    Console.Write(" Days: ");
                                                    int d = int.Parse(Console.ReadLine());
                                                    Console.Write(" Hours: ");
                                                    int h = int.Parse(Console.ReadLine());
                                                    Console.Write(" Minutes: ");
                                                    int m = int.Parse(Console.ReadLine());
                                                    Console.Write(" Seconds: ");
                                                    int s = int.Parse(Console.ReadLine());
                                                    Converter objject = new Converter(y, d, h, m, s);
                                                    Console.Clear();
                                                    objject.Minutes();
                                                    Console.Write("Calculate another time? Y/N ");
                                                    char c = Console.ReadKey().KeyChar;
                                                    if (c == 'n')
                                                    {
                                                        Console.Clear();
                                                        repeatFunc = false;
                                                    }
                                                    break;
                                                }
                                            case '5':
                                                {
                                                    Console.Clear();
                                                    Console.Write(" Years: ");
                                                    int y = int.Parse(Console.ReadLine());
                                                    Console.Write(" Days: ");
                                                    int d = int.Parse(Console.ReadLine());
                                                    Console.Write(" Hours: ");
                                                    int h = int.Parse(Console.ReadLine());
                                                    Console.Write(" Minutes: ");
                                                    int m = int.Parse(Console.ReadLine());
                                                    Console.Write(" Seconds: ");
                                                    int s = int.Parse(Console.ReadLine());
                                                    Converter objject = new Converter(y, d, h, m, s);
                                                    Console.Clear();
                                                    objject.Seconds();
                                                    Console.Write("Calculate another time? Y/N ");
                                                    char c = Console.ReadKey().KeyChar;
                                                    if (c == 'n')
                                                    {
                                                        Console.Clear();
                                                        repeatFunc = false;
                                                    }
                                                    break;
                                                }
                                            case 'x':
                                                {
                                                    repeatFunc = false;
                                                    break;
                                                }
                                            default:
                                                {
                                                    bool repeatDefault = true;
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Wrong input!");
                                                        Console.WriteLine("Continue? Y/N");
                                                        char c = Console.ReadKey().KeyChar;
                                                        if (c == 'y')
                                                        {
                                                            break;
                                                        }
                                                        else if (c == 'n')
                                                        {
                                                            repeatDefault = false;
                                                            Console.Clear();
                                                            repeatFunc = false;
                                                        }
                                                    } while (repeatDefault == true);
                                                    break;
                                                }
                                        }
                                    }
                                    catch { }
                                } while (repeatFunc == true);
                                break;
                            }
                        case '2': //Add Time to a Date
                            {
                                do 
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Type the date: ");
                                        Console.WriteLine("(dd/mm/yyyy xx:xx:xx)");
                                        string[] firstDate = Console.ReadLine().Split(' ', '/', ':', ',', '.').ToArray();
                                        Console.Clear();
                                        Console.WriteLine("Type the time to add: ");
                                        Console.WriteLine("(days/hours/minutes/seconds)");
                                        string[] secondDate = Console.ReadLine().Split(' ', '/', ':', ',', '.').ToArray();
                                        int day = int.Parse(firstDate[0]) + int.Parse(secondDate[0]);
                                        int month = int.Parse(firstDate[1]);
                                        int year = int.Parse(firstDate[2]);
                                        int hour = int.Parse(firstDate[3]) + int.Parse(secondDate[1]);
                                        int minutes = int.Parse(firstDate[4]) + int.Parse(secondDate[2]);
                                        int seconds = int.Parse(firstDate[5]) + int.Parse(secondDate[3]);
                                        Time_to_Date objject = new Time_to_Date(day, month, year, hour, minutes, seconds);
                                        objject.Calculate();
                                        Console.Write("Calculate [A]gain or [E]xit? ");
                                        char input = Console.ReadKey().KeyChar;
                                        if (input == 'e')
                                        {
                                            repeatFunc = false;
                                        }
                                    }
                                    catch {
                                        Console.Clear();
                                        Console.WriteLine("Wrong Input!");
                                        Console.ReadKey();
                                    }
                                } while (repeatFunc == true);
                                break;
                            }
                        case '1': //Add Local Time
                            {
                                do
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Type the time to add: ");
                                        Console.WriteLine("(days/hours/minutes/seconds)");
                                        string[] date = Console.ReadLine().Split(' ', '/', ':', ',', '.').ToArray();
                                        var local1 = local.AddDays(double.Parse(date[0]));
                                        local1 = local1.AddHours(double.Parse(date[1]));
                                        local1 = local1.AddMinutes(double.Parse(date[2]));
                                        local1 = local1.AddSeconds(double.Parse(date[3]));
                                        Console.Clear();
                                        Console.WriteLine(local1.ToString("ddd, dd/MM/yyyy HH:mm:ss"));
                                        Console.Write("\nCalculate [A]gain or [E]xit? ");
                                        char input = Console.ReadKey().KeyChar;
                                        if (input == 'e')
                                        {
                                            repeatFunc = false;
                                        }
                                    }
                                    catch
                                    {
                                        timer.Start();
                                        Console.Clear();
                                        Console.WriteLine("Wrong Input!");
                                    }
                                } while (repeatFunc == true);
                                break;
                            }
                        default:
                            {
                                bool repeatDefault = true;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Wrong input!");
                                    Console.WriteLine("Continue? Y/N");
                                    char c = Console.ReadKey().KeyChar;
                                    if (c == 'y')
                                    {
                                        break;
                                    }
                                    else if (c == 'n')
                                    {
                                        repeatDefault = false;
                                        Console.Clear();
                                        repeatChoser = false;
                                    }
                                } while (repeatDefault == true);
                                break;
                            }
                    }
                }
                catch { }
            } while (repeatChoser == true);
        }
    }
}
