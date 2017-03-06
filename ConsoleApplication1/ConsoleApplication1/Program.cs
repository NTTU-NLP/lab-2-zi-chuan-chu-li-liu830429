using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{

    class Program
    {

        static void Main(string[] args)
        {
            int m = 0;
            int p = 0, q = 0;

            using (StreamReader sr = new StreamReader(@"..\..\Data\Input.txt"))
            {

                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        if(ch==46)
                            Console.Write("\n");
                        else if(ch==63)
                            Console.Write("\n");
                        else if (ch == 33)
                            Console.Write("\n");
                        Console.Write(ch);
                        


                    }
                    //Console.Write("\n");



                }
               

            }
        }
    }
}