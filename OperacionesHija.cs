using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{

    public class OperacionesHija : Operaciones
    {
        public void ImprimirResultados(double largo, double ancho, double lado, double radio)
        {
            Console.WriteLine($"Área del rectángulo: {AreaRectangulo(largo, ancho)}");
            Console.WriteLine($"Volumen del cubo: {VolumenCubo(lado)}");
            Console.WriteLine($"Longitud de la circunferencia: {LongitudCircunferencia(radio)}");
        }
    }
}
