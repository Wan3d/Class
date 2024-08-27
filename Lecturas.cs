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
            archivo = new StreamReader("prueba.cpp");
            log = new StreamWriter("prueba.log");
        }
        public Lecturas(string nombre)
        {
            archivo = new StreamReader(nombre);
            log = new StreamWriter("prueba.log");
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
                    log.Write((char)(c + 2));
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
                    log.Write((char)(c - 2));
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
                    log.Write((char)('i'));
                }
                else
                {
                    log.Write(c);
                }
            }
        }
        public int contarLetras()
        {
            char c;
            int count = 0;
            while (!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                if (char.IsLetter(c))
                {
                    count++;
                }
                else
                {
                    log.Write(c);
                }

            }
            return count;
        }
        public int contarDigitos()
        {
            archivo.BaseStream.Position = 0;
            char c;
            int count2 = 0;
            while (!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                if (char.IsDigit(c))
                {
                    count2++;
                }
            }
            return count2;
        }
        public int contarEspacios()
        {
            archivo.BaseStream.Position = 0;
            char c;
            int count3 = 0;
            while (!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                if (char.IsWhiteSpace(c))
                {
                    count3++;
                }
            }
            return count3;
        }
        public char primerCaracter()
        {
            archivo.BaseStream.Position = 0;
            char c;
            char firstchar = '\0';
            while (!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                if (char.IsLetter(c))
                {
                firstchar = c;
                break;
                }
                else
                {
                log.Write(c);
                }
            }
            return firstchar;
        }
    }
}