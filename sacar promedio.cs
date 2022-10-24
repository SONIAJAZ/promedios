using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, w, z,calif,p,s,pts;
            Console.Write("Ingresa tus firmas max:");
             x= double.Parse(Console.ReadLine());
            Console.Write("solicita fimas de alumno:");
            y= double.Parse(Console.ReadLine());
            p= x * 0.8;
            s=(y*100)/x;
            if (s >= p) { }
            Console.Write("solicitar pts de examen: ");
            z= double.Parse(Console.ReadLine());
            Console.Write("solicitar pts de adap,ser,hacer : ");
            w= double.Parse(Console.ReadLine());
            calif=(x + y + w + z) / 100;
            if (calif < 7)
                Console.WriteLine("Reprobado");
            else
                Console.WriteLine("Aprobado");
            Console.WriteLine("Valor de promedio: " + calif);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar o");
            Console.ReadKey();
        }
    }
}
