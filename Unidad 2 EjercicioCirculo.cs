using System;

namespace EjercicioCirculo
{
    public class Circulo
    {
        // ATRIBUTO PRIVADO DE LA CLASE Circulo
        private double radio;

        // CONSTRUCTOR SIN ARGUMENTOS
        public Circulo()
        {
            // SE ASIGNA UN VALOR POR DEFECTO AL RADIO
            radio = 1.0;
        }

        // CONSTRUCTOR CON ARGUMENTO
        public Circulo(double radio)
        {
            // ESTRUCTURA DE CONTROL "IF" PARA VALIDAR QUE EL RADIO SEA MAYOR QUE CERO
            if (radio > 0)
            {
                this.radio = radio;
            }
            else
            {
                Console.WriteLine("Error: El radio debe ser mayor que 0. Se asignará 1.0 por defecto.");
                this.radio = 1.0;
            }
        }

        // METODO PUBLICO PARA OBTENER EL RADIO
        public double GetRadio()
        {
            return radio;
        }

        // METODO PUBLICO PARA CALCULAR EL AREA DEL CIRCULO
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // METODO PUBLICO PARA CALCULAR LA CIRCUNFERENCIA DEL CIRCULO
        public double CalcularCircunferencia()
        {
            return 2 * Math.PI * radio;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // =====================================
            // PRUEBA DE LA CLASE Circulo
            // =====================================

            Console.WriteLine("=== PRUEBA CLASE CIRCULO ===");

            // CREACION DE OBJETOS DE TIPO Circulo
            Circulo c1 = new Circulo();        // CONSTRUCTOR SIN ARGUMENTOS
            Circulo c2 = new Circulo(5.0);     // CONSTRUCTOR CON ARGUMENTO

            // MOSTRAR RESULTADOS DEL PRIMER CIRCULO
            Console.WriteLine($"\nCIRCULO 1 (RADIO POR DEFECTO = {c1.GetRadio()})");
            Console.WriteLine($"Area: {c1.CalcularArea():F2}");
            Console.WriteLine($"Circunferencia: {c1.CalcularCircunferencia():F2}");

            // MOSTRAR RESULTADOS DEL SEGUNDO CIRCULO
            Console.WriteLine($"\nCIRCULO 2 (RADIO = {c2.GetRadio()})");
            Console.WriteLine($"Area: {c2.CalcularArea():F2}");
            Console.WriteLine($"Circunferencia: {c2.CalcularCircunferencia():F2}");

            Console.ReadKey();
        }
    }
}
