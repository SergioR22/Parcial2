using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class Ejercicio1
    {
        public void Uno()
        {
            int num1, num2, Resultado;
            Console.WriteLine("Ingrese primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
            }
            else if (num1 > 1 && num2 < 1000000000)
            {
                Resultado = num1 * num2;
                Console.WriteLine("El resultado de la multiplicacion es: " + Resultado);
            }
        }
            
    }
}
