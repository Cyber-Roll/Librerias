using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Libreria de clases de utilidad para trabajar con Consola
namespace LibConsola
{
    public class Print
    {
        /// <summary>
        /// Imprime el título enviado en color amarillo y azul
        /// </summary>
        /// <param name="Titulo"></param>
        public static void Titulo(char Caracter, int Largo, string Titulo)
        {            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            int LongAux = (Largo - (Titulo.Length + 2)) / 2;
            Console.WriteLine(new string(Caracter   , Largo));
            Console.WriteLine(new string(Caracter, LongAux) + $" {Titulo} " + new string(Caracter, LongAux));            
            Console.WriteLine(new string(Caracter, Largo));
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
