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
        public static char Caracter { get; set; } = '█';
        public static int Largo { get; set; } = 80;
        public static int Margen { get; set; } = 3;
        /// <summary>
        /// Imprime tres líneas como título, en la línea del centro (centrado) va el título
        /// El carácter de impresión esta definido '█' y accesible como static: Caracter
        /// El largo a imprimir en el pantalla es 80, accesible como static: Largo
        /// El ancho del Margen en el pantalla es 3, accesible como static: Margen
        /// </summary>
        /// <param name="Titulo"></param>
        public static void Titulo3(string Titulo)//char Caracter, int Largo, string Titulo)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            int LongAux = (Largo - (Titulo.Length + 2)) / 2;
            Console.WriteLine(new string(Caracter, Largo));
            Console.WriteLine(new string(Caracter, LongAux) + $" {Titulo} " + new string(Caracter, LongAux + (Titulo.Length % 2)));
            Console.WriteLine(new string(Caracter, Largo));
            Console.BackgroundColor = ConsoleColor.Black;

        }
        /// <summary>
        /// Imprime una línea como título, en la línea (centrado) va el título
        /// El carácter de impresión esta definido '█' y accesible como static: Caracter
        /// El largo a imprimir en el pantalla es 80, accesible como static: Largo
        /// El ancho del Margen en el pantalla es 3, accesible como static: Margen
        /// </summary>
        /// <param name="Titulo"></param>
        public static void Titulo1(string Titulo) //char Caracter, int Largo, string Titulo)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            int LongAux = (Largo - (Titulo.Length + 2)) / 2;
            Console.WriteLine(new string(Caracter, LongAux) + $" {Titulo} " + new string(Caracter, LongAux + (Titulo.Length % 2)));
            Console.BackgroundColor = ConsoleColor.Black;
        }
        /// <summary>
        /// Imprime varias líneas de error
        /// El carácter de impresión esta definido '█' y accesible como static: Caracter
        /// El largo a imprimir en el pantalla es 80, accesible como static: Largo
        /// El ancho del Margen en el pantalla es 3, accesible como static: Margen
        /// </summary>
        /// <param name="Titulo"></param>
        public static void ErrorGeneral(string Titulo)
        {
            // Console.WriteLine($" {Titulo}");

            var ColorFore = Console.ForegroundColor;
            var ColorBack = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Titulo = Titulo.Replace('\r', ' ');
            string[] Titulos = Titulo.Split('\n');
            foreach (string titulo in Titulos)
            {
                int MargenAux = Margen;
                int LargoRestante = titulo.Length;
                int LargoUtil = Largo - 2 - 2 * Margen;
                int Size = 0;
                int desde = 0;
                while (LargoRestante > 0)
                {
                    if (LargoRestante > LargoUtil) Size = LargoUtil;
                    else
                    {
                        Size = LargoRestante;
                        MargenAux = (Largo - LargoRestante - 2 - (LargoRestante % 2)) / 2;
                    }
                    string sImprimir = titulo.Substring(desde, Size);
                    Console.WriteLine(new string(Caracter, MargenAux) + $" {sImprimir} " + new string(Caracter, MargenAux + (sImprimir.Length % 2)));
                    desde += LargoUtil;
                    LargoRestante -= Size;
                }
            }
            Console.ForegroundColor = ColorFore;
            Console.ForegroundColor = ColorFore;
            Console.BackgroundColor = ColorBack;

        }

    }
}
