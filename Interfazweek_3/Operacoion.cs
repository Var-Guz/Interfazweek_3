
using System;

namespace Interfazweek_3
{
    public class Operacoion : IOperacion, IArea
    {
        public double N1 { get; set; }
        public double N2 { get; set; }

        public double Cuadrado()
        {
            return N1 * N2;

        }

        public double Division()
        {
            if (N1 == 0) { 
                    Console.WriteLine("no se puede dividir entre cero");
                return 0;       
            }
            return N1 / N2;
        } 

        public double Multiplicacion()
        {
            return N1 * N2;
        }

        public double Resta()
        {
            return N1 - N2;
        }

        public double Suma()
        {
            return N1 + N2;
        }

        public double Triangulo()
        {
            return (N1 * N2) / 2;

        }
        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"SUMA: {Suma()}");
            Console.WriteLine($"RESTA: {Resta()}");
            Console.WriteLine($"MULTIPLICACION: {Multiplicacion()}");
            Console.WriteLine($"DIVISION: {Division()}");
            Console.WriteLine($"Area del cuadrado: {Cuadrado()} cm2");
            Console.WriteLine($"Area del triangulo: {Triangulo()} cm2");
        }
        
    }

}
