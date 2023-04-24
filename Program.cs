using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejemplode_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arreglo ={ {8, 12, 11, 34, 56, 67 }, { 9,3, 2, 1, 22, 78} };
            Imprimirarreglo(arreglo);
            Console.ReadLine(); 
        }

        public static void Imprimirarreglo(int[,]arreglo) {
            Console.WriteLine("Elementos del arreglo");
            foreach (int a in arreglo) { 
            Console.Write(" "+a);
            
            
            }
            Ordenar ordenar = new Ordenar();
            ordenar.Ordenaarray(arreglo);
        
        }
    }
}
