using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Users users = new Users(4, "");
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                Users users = new Users(5, "Anjali");

            }
            catch (NameException nameex)
            {
                Console.WriteLine(nameex.Message);

            }
        }
    }
}
