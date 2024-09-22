using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Version1_3
    {
        static void MainV1_3(string[] args)
        {
            const int TRANSACTION_SZ = 5;
            int[] data = new int[TRANSACTION_SZ];
            Date[] date = new Date[TRANSACTION_SZ];

            while (true)
            {
                Console.WriteLine("1) Read 2) Print 3) Quit");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter " + TRANSACTION_SZ + " transaction values:");

                    for (int i = 0; i < TRANSACTION_SZ; i++)
                    {
                        Console.Write("Val: ");
                        string val = Console.ReadLine();
                        data[i] = int.Parse(val);

                        Console.Write("Day: ");
                        val = Console.ReadLine();
                        date[i] = new Date();
                        date[i].day = int.Parse(val);

                        Console.Write("Month: ");
                        val = Console.ReadLine();
                        date[i].month = int.Parse(val);

                        Console.Write("Year: ");
                        val = Console.ReadLine();
                        date[i].year = int.Parse(val);
                    }
                }
                else if (option == "2")
                {
                    Console.WriteLine("Transaction values:");
                    for (int i = 0; i < TRANSACTION_SZ; i++)
                    {
                        Console.WriteLine("Val: " + data[i]);
                        Console.WriteLine("Day: " + date[i].day);
                        Console.WriteLine("Month: " + date[i].month);
                        Console.WriteLine("Year: " + date[i].year);
                    }
                }
                else if (option == "3")
                {
                    break;
                }
            }
        }
    }
