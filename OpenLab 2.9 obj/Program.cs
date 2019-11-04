using System;

namespace OpenLab_2._9_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Juraj";
            string lastname = "Orlický";
            Class1 priezviskomeno = new Class1();
            Console.WriteLine(priezviskomeno.menopriezvisko(firstname, lastname));
        }
    }
}
