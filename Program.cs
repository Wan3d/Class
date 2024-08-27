using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Lecturas L = new Lecturas("prueba.cpp"))
            {
                Console.WriteLine("El número de letras en el archivo es: " + L.contarLetras());
                Console.WriteLine("El número de digitos en el archivo es: " + L.contarDigitos());
                Console.WriteLine("El número de espacios en el archivo es: " + L.contarEspacios());
                Console.WriteLine("El primer caracter del archivo es: " + L.primerCaracter());



            }
        }
    }
}
