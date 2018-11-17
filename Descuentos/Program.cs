using System;

namespace Descuentos
{
    class Program
    {
        static void Main(string[] args)
        {

            //En el siguiente paso declararemos todas las variables que utilizaremos para el programa

            double kilosDePatatas;
            double precioFinal;
            string precioFinalTotal;
            double precioFinalConDesc10;
            double precioFinalConDesc20;
            double precioDespuesDescuento = 0.0;
            double resultado;
            
            //En el siguiente paso se solicitará al usuario que introduzca el número de kilos que el cliente ha comprado, posteriormente introduciento el valor de un kilo de patatas

            Console.WriteLine("Introduzca el número de Kilos que el cliente ha comprado");
            kilosDePatatas = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el valor en euros de un kilo de patatas");
            precioFinal = double.Parse(Console.ReadLine());

            resultado = precioFinal * kilosDePatatas; //Lo que hacemos en esta operación es calcular el precio bruto de la compra del cliente

            //En el siguiente paso declararemos las variables y las operaciones necesarias para calcular los porcentajes del descuento

            precioFinalConDesc10 = resultado * 0.10; //Descuento del 10%
            precioFinalConDesc20 = resultado * 0.20; //Descuento del 20%

            //En el siguiente paso se indicará por consola el precio bruto de la compra antes de ningún cálculo de descuento/IVA.

            Console.WriteLine("El precio bruto de la compra es " + resultado);
            
            //Para calcular el porcentaje a descontar a partir del resultado realizaremos unas condiciones para los diferentes casos
            
            if (resultado < 50) //Cuando el precio bruto sea menor que 50, no se realizará ningún descuento, indicándolo por consola
            {
                precioDespuesDescuento = resultado;
                Console.WriteLine("El total de la compra es " + resultado + " siendo menor que 50 euros, por tanto no existe ningún descuento para este caso");
            }
            else if (resultado < 100) //Cuando el precio bruto sea mayor que 50 y menor que 100, se realizará un 10% de descuento, indicándolo por consola
            {
                precioDespuesDescuento = resultado - precioFinalConDesc10;
                Console.WriteLine("El total de la compra es " + resultado + " siendo mayor que 50 euros y menor que 100 euros, por tanto tiene un descuento asignado de un 10%");
                Console.WriteLine("El precio final con descuento es " + precioDespuesDescuento);
            }
            else if (resultado >= 100) //Cuando el precio bruto sea mayor que 100, se realizará un 20% de descuento, indicándolo por consola
            {
                precioDespuesDescuento = resultado - precioFinalConDesc20;
                Console.WriteLine("El total de la compra es " + resultado + " siendo mayor que 100 euros, por tanto tiene un descuento asignado de un 20%");
                Console.WriteLine("El precio final con descuento es " + precioDespuesDescuento);
            }

            Console.WriteLine("¿El cliente es Particular o Empresa?"); //En esta línea se solicitará al gerente que introduzca si el cliente es particular o empresa, para a partir de ahi calcular el IVA o no
            precioFinalTotal = Console.ReadLine();


            double precioConIva = precioDespuesDescuento * 0.21 + precioDespuesDescuento; //En esta línea calculamos y sumamos el 21% del total con descuento, para en caso de ser particular, aplicárselo
        

            //Para el siguiente paso, se realiza un switch con dos casos posibles dependiendo de lo que el gerente introduzca en consola, y a partir de ahi realizar las operaciones de cada uno

            switch (precioFinalTotal)
            {
                case "Empresa": //Si el gerente indica que el cliente es empresa, no se realizará ningún cambio al precio final con descuento
                    {
                        Console.WriteLine("El cliente es una empresa, por tanto el precio final es " + precioDespuesDescuento);
                        break;
                    }

                case "Particular": //Si el gerente indica que el cliente es particular, se aplicará y sumará el 21% al precio final con descuento, siendo la variable "precioConIva"
                    {
                        Console.WriteLine("El cliente es un particular, por tanto al precio con descuento habría que incrementar el IVA, quedando finalmente " + precioConIva);
                        break;
                    }

            }

            //En el siguiente comando lo que hará el programa será esperar a un toque de teclado para proceder a la finalización del programa

            Console.ReadKey();
        }
    }
}
