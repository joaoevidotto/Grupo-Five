using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace meu_software
{
    class Program
    {
        static void Main(string[] args)
        {

            string diretorio = @"C:\MEU SOFTWARE\";


            Directory.CreateDirectory(diretorio);
            try
            {
                if (!File.Exists(diretorio + "cadastro" + ".txt"))
                {
                    File.Create(diretorio + "cadastro" + ".txt");
                    Console.WriteLine("Diretorio criado");
                }
                else
                {
                    Stream leitor = File.Open(diretorio + "cadastro" + ".txt", FileMode.Append);
                    StreamWriter gravador = new StreamWriter(leitor);
                   
                    gravador.Close();
                    leitor.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro!" + e.Message);
            }
            Console.ReadKey();
        }
    }
}
