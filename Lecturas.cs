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
        public void Copy()
        {
        while (!archivo.EndOfStream)
    {
       log.Write((char)archivo.Read()); 
    }
        }
         public void Encrypt()
        {
            char c;
        while (!archivo.EndOfStream)
    {
        c = (char)archivo.Read();
        if (char.IsLetter(c))
        {
        log.Write((char)(c+2));
        }
        else
        {
        log.Write(c);
        }
    
        }
        }
        public void DesEncrypt()
        {
            char c;
        while (!archivo.EndOfStream)
    {
        c = (char)archivo.Read();
        if (char.IsLetter(c))
        {
        log.Write((char)(c-2));
        }
        else
        {
        log.Write(c);
        }
    
        }
        }
        public void Encrypt2()
        {
        char c;
        while (!archivo.EndOfStream)
        {
        c = (char)archivo.Read();
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
        log.Write((char)('o'));
        }
        else
        {
        log.Write(c);
        }
        }
        }
    }
}