using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string X = "X";
            string O = "O";
            string draw = "DRAW!!!";
            string defeat = "DEFEAT!!!";

            string desk = ("\n ----------------" +
                  "\n  | 1 | 2 | 3 | " +
                  "\n -+---+---+---+-" +
                  "\n  | 4 | 5 | 6 | " +
                  "\n -+---+---+---+-" +
                  "\n  | 7 | 8 | 9 | " +
                  "\n ----------------");

            Console.WriteLine(desk);
            Console.Write("X: ");
            string ans = Console.ReadLine();

            if (ans == "1")
            {
                Console.Clear();
                string rep = desk.Replace("1", X);
                string rep1 = rep.Replace("5", O);
                Console.WriteLine(rep1);
                Console.Write("X: ");
                string ans2 = Console.ReadLine();

                if (ans2 == "4")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("4", X);
                    string rep3 = rep2.Replace("7", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("2", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                }

                else if (ans2 == "7")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("7", X);
                    string rep3 = rep2.Replace("4", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("2", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans3 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                }

                else if (ans2 == "2")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("2", X);
                    string rep3 = rep2.Replace("3", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.Write(defeat);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                }

                else if (ans2 == "3")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("3", X);
                    string rep3 = rep2.Replace("2", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                }
                else if (ans2 == "6")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("6", X);
                    string rep3 = rep2.Replace("3", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                }
                else if (ans2 == "8")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("8", X);
                    string rep3 = rep2.Replace("7", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("2", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }
                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }

                else if (ans2 == "9")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("9", X);
                    string rep3 = rep2.Replace("6", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("2", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }
            }

            else if (ans == "2")
            {
                Console.Clear();
                string rep = desk.Replace("2", X);
                string rep1 = rep.Replace("5", O);
                Console.WriteLine(rep1);
                Console.Write("X: ");
                string ans2 = Console.ReadLine();

                if (ans2 == "1")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("1", X);
                    string rep3 = rep2.Replace("3", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }
                    }
                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                }

                if (ans2 == "3")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("3", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }
                    }
                }
                if (ans2 == "4")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("4", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }
                }

                if (ans2 == "6")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("6", X);
                    string rep3 = rep2.Replace("3", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "1")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("1", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }
                }

                if (ans2 == "7")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("7", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }
                }

                if (ans2 == "8")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("8", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }
                }

                if (ans2 == "9")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("9", X);
                    string rep3 = rep2.Replace("3", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "1")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("1", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("1", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }
                }
            }

            else if (ans == "3")
            {
                Console.Clear();
                string rep = desk.Replace("3", X);
                string rep1 = rep.Replace("5", O);
                Console.WriteLine(rep1);
                Console.Write("X: ");
                string ans2 = Console.ReadLine();

                if (ans2 == "1")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("1", X);
                    string rep3 = rep2.Replace("2", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }
                    }
                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                }
                
                if (ans2 == "2")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("2", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }
                    }
                }
                if (ans2 == "4")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("4", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }
                }

                if (ans2 == "6")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("6", X);
                    string rep3 = rep2.Replace("9", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("2", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4") 
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("1", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                    
                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }

                if (ans2 == "7")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("7", X);
                    string rep3 = rep2.Replace("4", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "1")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("1", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("1", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("1", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(draw);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }
                }

                if (ans2 == "8")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("8", X);
                    string rep3 = rep2.Replace("9", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("2", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "1")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("1", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("1", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("1", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("1", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("1", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }

                if (ans2 == "9")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("9", X);
                    string rep3 = rep2.Replace("6", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("2", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();
                        
                        if (ans4 == "1")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("1", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }

            }

            else if (ans == "4")
            {
                Console.Clear();
                string rep = desk.Replace("4", X);
                string rep1 = rep.Replace("5", O);
                Console.WriteLine(rep1);
                Console.Write("X: ");
                string ans2 = Console.ReadLine();

                if (ans2 == "1")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("1", X);
                    string rep3 = rep2.Replace("7", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("2", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);

                    }
                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }

                if (ans2 == "2")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("2", X);
                    string rep3 = rep2.Replace("7", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("1", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }
                if (ans2 == "3")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("3", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }
                }

                if (ans2 == "6")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("6", X);
                    string rep3 = rep2.Replace("9", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("1", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("1", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }

                if (ans2 == "7")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("7", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }
                }

                if (ans2 == "8")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("8", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }
                }

                if (ans2 == "9")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("9", X);
                    string rep3 = rep2.Replace("7", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "1")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("1", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("1", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }
            }

            else if (ans == "5")
            {
                Console.Clear();
                string rep = desk.Replace("5", X);
                string rep1 = rep.Replace("1", O);
                Console.WriteLine(rep1);
                Console.Write("X: ");
                string ans2 = Console.ReadLine();

                if (ans2 == "2")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("2", X);
                    string rep3 = rep2.Replace("8", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("4", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                            if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }
                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);

                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("4", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }
                }

                if (ans2 == "3")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("3", X);
                    string rep3 = rep2.Replace("7", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "4")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("4", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);

                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }

                    if (ans3 == "4")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("4", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("4", O);
                        string rep6 = rep5.Replace("9", O);
                        Console.WriteLine(rep6);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        string rep6 = rep5.Replace("2", O);
                        Console.WriteLine(rep6);
                        Console.WriteLine(draw);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }
                    }
                }
                if (ans2 == "4")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("4", X);
                    string rep3 = rep2.Replace("6", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("2", O);
                            string rep8 = rep7.Replace("9", O);
                            Console.WriteLine(rep8);
                            Console.WriteLine(defeat);
                        }

                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("2", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("9", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }
                    }
                    //end
                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "7")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("7", X);
                            string rep7 = rep6.Replace("8", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("7", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }
                }

                if (ans2 == "--")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("6", X);
                    string rep3 = rep2.Replace("9", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "9")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("9", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("1", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("1", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }

                if (ans2 == "--")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("7", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("8", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }
                }

                if (ans2 == "8")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("8", X);
                    string rep3 = rep2.Replace("1", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "7")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("7", X);
                        string rep5 = rep4.Replace("9", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "9")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("9", X);
                        string rep5 = rep4.Replace("7", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                        if (ans4 == "3")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("3", X);
                            string rep7 = rep6.Replace("6", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "6")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("6", X);
                            string rep7 = rep6.Replace("3", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }
                }

                if (ans2 == "9")
                {
                    Console.Clear();
                    string rep2 = rep1.Replace("9", X);
                    string rep3 = rep2.Replace("7", O);
                    Console.WriteLine(rep3);
                    Console.Write("X: ");
                    string ans3 = Console.ReadLine();

                    if (ans3 == "1")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("1", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "2")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("2", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }

                    if (ans3 == "3")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("3", X);
                        string rep5 = rep4.Replace("6", O);
                        Console.WriteLine(rep5);
                        Console.Write("X: ");
                        string ans4 = Console.ReadLine();

                        if (ans4 == "1")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("1", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "2")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("2", X);
                            string rep7 = rep6.Replace("1", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(draw);
                        }

                        if (ans4 == "8")
                        {
                            Console.Clear();
                            string rep6 = rep5.Replace("8", X);
                            string rep7 = rep6.Replace("2", O);
                            Console.WriteLine(rep7);
                            Console.WriteLine(defeat);
                        }

                    }

                    if (ans3 == "6")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("6", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.Write(defeat);
                    }

                    if (ans3 == "8")
                    {
                        Console.Clear();
                        string rep4 = rep3.Replace("8", X);
                        string rep5 = rep4.Replace("3", O);
                        Console.WriteLine(rep5);
                        Console.WriteLine(defeat);
                    }
                }
            }

        }
    }
}
