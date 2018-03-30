using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "allo";
            string pass = "mdp";
            Console.WriteLine("SELECT Count(*) AS 'nbrusers' FROM connexion WHERE users = \"" + test + "\" AND password = \"" + pass + "\"");
            Console.ReadKey();
        }
    }
}