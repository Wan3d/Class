using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Prueba
{
    public class Lecturas : IDisposable
    {
        StreamReader archivo;
        StreamWriter log;
        public Lecturas()
        {
            Console.WriteLine("Constructor 1");
            archivo = new StreamReader("prueba.cpp");
            log     = new StreamWriter("prueba.log");
        }
        public Lecturas(string nombre)
        {
            Console.WriteLine("Constructor 2");
            archivo = new StreamReader(nombre);
            log     = new StreamWriter("prueba.log");
        }
        
        public void Dispose()
        {
            Console.WriteLine("Destructor");
            archivo.Close();
            log.Close();
        }
    }
}