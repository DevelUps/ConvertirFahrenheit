using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            float gradosC, gradosF;
            // pedimos al usuario ingresar los valores
            Console.Write("Por favor ingresa los grados °C:   ");
            // se inicializa la variable y se convierte el string recibido
            gradosC = float.Parse(Console.ReadLine());
            // Realizamos la convercion de °C a °F
            gradosF = (gradosC * 1.8f) + 32;
            // Mostramos resultado en pantala
            Console.WriteLine("{0}C° Convertidos en Fahrenheit es {1} °F, ", gradosC, gradosF);
        }
    }
}
