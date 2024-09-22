using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Version1_2
    {
        static void MainV1_2(string[] args)
        {
            const int TRANSACTION_SZ = 5;
            int[] data = new int[TRANSACTION_SZ];
            int[] day = new int[TRANSACTION_SZ];
            int[] month = new int[TRANSACTION_SZ];
            int[] year = new int[TRANSACTION_SZ];

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
                        day[i] = int.Parse(val);

                        Console.Write("Month: ");
                        val = Console.ReadLine();
                        month[i] = int.Parse(val);

                        Console.Write("Year: ");
                        val = Console.ReadLine();
                        year[i] = int.Parse(val);
                    }
                }
                else if (option == "2")
                {
                    Console.WriteLine("Transaction values:");
                    for (int i = 0; i < TRANSACTION_SZ; i++)
                    {
                        Console.WriteLine("Val: " + data[i]);
                        Console.WriteLine("Day: " + day[i]);
                        Console.WriteLine("Month: " + month[i]);
                        Console.WriteLine("Year: " + year[i]);
                    }
                }
                else if (option == "3")
                {
                    break;
                }
            }
        }

    }
