using System;

namespace EjercicioProducto
{
    public class Producto
    {
        // ATRIBUTOS PRIVADOS DE LA CLASE Producto
        private int id;
        private string nombre;
        private double precio;
        private int stock;

        // PROPIEDAD PUBLICA Id
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // PROPIEDAD PUBLICA Nombre
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // PROPIEDAD PUBLICA Precio CON VALIDACION
        public double Precio
        {
            get { return precio; }
            set
            {
                // ESTRUCTURA DE CONTROL "IF" PARA VALIDAR QUE EL PRECIO NO SEA NEGATIVO
                if (value < 0)
                {
                    Console.WriteLine("Error: El precio no puede ser negativo.");
                }
                else
                {
                    precio = value;
                }
            }
        }

        // PROPIEDAD PUBLICA Stock CON VALIDACION
        public int Stock
        {
            get { return stock; }
            set
            {
                // ESTRUCTURA DE CONTROL "IF" PARA VALIDAR QUE EL STOCK NO SEA MENOR QUE CERO
                if (value < 0)
                {
                    Console.WriteLine("Error: El stock no puede ser menor que 0.");
                }
                else
                {
                    stock = value;
                }
            }
        }

        // METODO PUBLICO PARA DESCONTAR STOCK
        public void DescontarStock(int cantidad)
        {
            // VALIDACION PARA QUE LA CANTIDAD NO SEA NEGATIVA
            if (cantidad < 0)
            {
                Console.WriteLine("Error: La cantidad no puede ser negativa.");
                return;
            }

            // VALIDACION PARA EVITAR STOCK NEGATIVO
            if (stock - cantidad < 0)
            {
                Console.WriteLine("Error: No hay suficiente stock disponible.");
            }
            else
            {
                stock -= cantidad;
                Console.WriteLine($"Stock actualizado. Nuevo stock: {stock}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // =====================================
            // PRUEBA DE LA CLASE Producto
            // =====================================

            Console.WriteLine("=== PRUEBA CLASE PRODUCTO ===");

            // CREACION DE UN OBJETO DE TIPO Producto
            Producto p1 = new Producto();

            // ASIGNACION DE VALORES VALIDOS
            p1.Id = 1;
            p1.Nombre = "Laptop";
            p1.Precio = 1500.50;
            p1.Stock = 10;

            // MOSTRAR VALORES INICIALES
            Console.WriteLine($"Producto: {p1.Nombre}");
            Console.WriteLine($"Precio: {p1.Precio}");
            Console.WriteLine($"Stock: {p1.Stock}");

            // ASIGNACION DE VALORES INVALIDOS PARA PROBAR VALIDACIONES
            Console.WriteLine("\n--- PRUEBA DE VALIDACIONES ---");
            p1.Precio = -200;
            p1.Stock = -5;

            // PRUEBA DEL METODO DescontarStock
            Console.WriteLine("\n--- PRUEBA METODO DescontarStock ---");
            p1.DescontarStock(3);     // CASO VALIDO
            p1.DescontarStock(20);    // CASO INVALIDO
            p1.DescontarStock(-2);    // CASO INVALIDO

            Console.ReadKey();
        }
    }
}
