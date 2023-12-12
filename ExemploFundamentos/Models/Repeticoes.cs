using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Repeticoes
    {
        public void ExecutarRepeticoes()
        {
            int contador = 5;

            for (int numero = 0; numero <= 5; numero++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }
    }
}