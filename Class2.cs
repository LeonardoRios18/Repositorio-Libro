using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificacionesprograma
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = "";// se cambio el tipo de dato de un char a un var

            Console.Write("caracter: ");
            car = Console.ReadLine();
            Console.WriteLine($"{car}"); // se llamo a la variable

            // se borraron las 3 lineas de codigo que estaban repetidas

            Console.ReadLine();// se agrego un ReadLine
        }
    }
}
