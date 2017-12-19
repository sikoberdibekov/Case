using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, r = 0;
                char op;
                bool ok = true;
                Console.Write("A= ");
                a = double.Parse(Console.ReadLine());
                Console.Write("OP= ");
                op = char.Parse(Console.ReadLine());
                Console.Write("B= ");
                b = double.Parse(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        r = a + b;
                        break;
                    case '-':
                        r = a - b;
                        break;
                    case '*':
                        r = a * b;
                        break;
                    case ':':
                    case '/':
                        r = a / b;
                        break;
                    default:
                        ok = false;
                        break;
                }
                if (ok)
                    Console.WriteLine("{0} {1} {2} = {3}", a, op, b, r);
                else
                    Console.WriteLine("Операция не определена");
            }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
            Console.ReadKey();
        }
        }
    }
