using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{

    static void MainV1_0(string[] args)
        {
        const int TRANSACTION_SZ = 5;
        int[] data = new int[TRANSACTION_SZ];

        Console.WriteLine("1) Read 2) Print");
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
        }
 
}