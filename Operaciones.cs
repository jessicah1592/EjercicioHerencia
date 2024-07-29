using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{

    public class Operaciones
    {
        public double AreaRectangulo(double largo, double ancho)
        {
            return largo * ancho;
        }

        public double VolumenCubo(double lado)
        {
            return lado * lado * lado;
        }

        public double LongitudCircunferencia(double radio)
        {
            return 2 * 3.14159 * radio;
        }
    }
}
