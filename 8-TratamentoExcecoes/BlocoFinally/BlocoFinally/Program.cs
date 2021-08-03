using System;
using System.IO;

namespace BlocoFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bloco finally: É um bloco que contém código a ser executado independentemente de ter ocorrido ou não uma exceção.
            //Exemplo clássico : fechar um arquivo ou conexão de banco de dados ao final do processamento.
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}