using System;
namespace EjercicioHerencia;
class Program
{
    public static void Main (string[] args){

        OperacionesHija operacion = new OperacionesHija();
        double largo = 10;
        double ancho = 5;
        double lado = 3;
        double radio = 7;

        operacion.ImprimirResultados(largo, ancho, lado, radio);

    }
}
