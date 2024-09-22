using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Version1_1
    {
        static void Main1_1(string[] args)
        {
            const int TRANSACTION_SZ = 5;
            int[] data = new int[TRANSACTION_SZ];

            while (true)
            {
                Console.WriteLine("1) Read 2) Print 3) Quit");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter " + TRANSACTION_SZ + " transaction values:");

                    for (int i = 0; i < TRANSACTION_SZ; i++)
                    {
                        string val = Console.ReadLine();
                        data[i] = int.Parse(val);
                    }
                }
                else if (option == "2")
                {
                    Console.WriteLine("Transaction values:");
                    for (int i = 0; i < TRANSACTION_SZ; i++)
                    {
                        Console.WriteLine(data[i]);
                    }
                }
                else if (option == "3")
                {
                    break;
                }
            }
        }

    }

