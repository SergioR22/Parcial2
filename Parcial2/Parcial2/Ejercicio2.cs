using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class Ejercicio2
    {
        public void Dos()
        {
            int num1, num2, Resultado;
            Console.WriteLine("Ingrese primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
            else if (num1 > 1 && num2<1000000000)
            {
                Resultado = num1/num2;
                Console.WriteLine("El resultado de la division es: " + Resultado);
            }
        }
    }
}
