namespace portafolioC_
{
    internal class Retos6y7
    {
        /* RETO 6
        Al ejercicio de Supermercados Noé, agregar
    
        ❑ Posibilidad para registrar precio y cantidad de los productos
        adquiridos por un cliente (sin importar la cantidad) en lugar
        de recibir el valor de la compra.
        ❑ Implementar un acumulador que calcule el valor a pagar luego de
        registrar los productos
        ❑ Mantenga la comprobación de si es beneficiado con el descuento
        por su compra
        ❑ Mantenga la generación de la bolita aleatoriamente
        ❑ Mantenga el mensaje al usuario que le dice si obtuvo un descuento y
        muestre cual es el valor final a pagar con el descuento aplicado
        ❑ Capture el valor con el que el cliente paga
        ❑ Calcule y muestre el cambio.
        */
        public static void reto6()
        {
            string continua = "";
            float totalConDescuento = 0;
            int totalCompra = 0;
            int cantidadProductos = 0;
            int valorUnitarioProducto = 0;
            float porcentajeDescuento = 0;

            Random random = new Random();
            int bola = random.Next(1, 5);
            float valorAPagar = 0;
            float vueltas = 0;

            do
            {
                Console.WriteLine(
                    "Digite cuantos productos de una misma referencia desea ingresar"
                );
                cantidadProductos = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el valor unitario del producto");
                valorUnitarioProducto = int.Parse(Console.ReadLine());

                totalCompra += cantidadProductos * valorUnitarioProducto;

                Console.WriteLine(
                    $"Ha ingresado {cantidadProductos} de productos de la misma referencia \npor un valor unitario de {valorUnitarioProducto} \npara un total de {cantidadProductos * valorUnitarioProducto}"
                );

                Console.WriteLine("Desea registrar un nuevo producto? Si/No");
                continua = (Console.ReadLine()).ToUpper();
            } while (continua == "SI");

            Console.WriteLine($"USted ha hecho una compra por un total de ${totalCompra}");

            if (totalCompra >= 50000)
            {
                Console.WriteLine(
                    "Felicidades usted ha sido seleccionado para participar en nuestro sorteo! \nEl total que debes pagar de tu compra, es {totalConDescuento} pesos"
                );

                if (bola == 1)
                    porcentajeDescuento = 0.1f;
                else if (bola == 2)
                    porcentajeDescuento = 0.3f;
                else if (bola == 3)
                    porcentajeDescuento = 0.5f;
                else
                    porcentajeDescuento = 1.0f;

                totalConDescuento = totalCompra - (totalCompra * porcentajeDescuento);

                string bolita =
                    bola == 1
                        ? "Roja"
                        : bola == 2
                            ? "Azul"
                            : bola == 3
                                ? "Amarila"
                                : "Blanca";

                Console.WriteLine(
                    $"Has sacado la bolita {bolita}!!! tu descuento será de el {porcentajeDescuento * 100}% de su compra"
                );
            }
            else

                Console.WriteLine(
                    "Recuerda que por compras mayores a $50000 puedes participar en nuestor sorteo, animate, puedes ser un ganador!!!"
                );

            Console.WriteLine("Con cuanto va a pagar?");
            valorAPagar = float.Parse(Console.ReadLine());
            vueltas = valorAPagar - totalConDescuento;
            Console.WriteLine($"El dinero a devolver es ${vueltas}");

            Console.WriteLine(
                $"El total que debes pagar de tu compra, es {totalConDescuento} pesos"
            );
        }

        /* RETO 7
        Retome los conceptos de acumulador y contador vistos. Aplique las
        estructuras algorítmicas vistas al juego del carisellazo:
        
        ❑ Definir un valor global para apostar
        ❑ Repetir el juego las veces que el jugador lo desee.
        ❑ Posibilidad para apostar una cantidad de dinero específica (ingresada
        
        por el usuario) en cada jugada
        
        ❑ Cada vez que el jugador gane debe duplicar el valor apostado y
        
        acumular el valor ganado al valor global.
        
        ❑ Cada vez que pierda debe restar al valor apostado del valor global
        ❑ Al final del juego debe decirle la cantidad de veces que jugó y el
        dinero que acumuló.
        */
        public static void reto7()
        {
            Random random = new Random();
            int moneda = random.Next(0, 2); // 0 cara 1 sello
            int elecion,
                valorGlobal,
                valorGanado,
                valorPerdido,
                valorApuesta;
            bool seguir;

            Console.WriteLine("Digite la suma que quiere administrar");
            valorGlobal = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("cuanto desea apostar?");
                valorApuesta = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite Su elecion, 1. cara o 2. sello ");
                elecion = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("Realizando lanzamiento en 3... 2... 1... ");
                string resultado = moneda == 0 ? "Cara" : "Sello";
                Console.WriteLine($"La moneda ha caido en {resultado}");

                if (moneda == elecion)
                {
                    valorGlobal += valorApuesta;
                    valorGanado += valorApuesta * 2;
                    Console.WriteLine("Ganaste");
                }
                else
                {
                    valorGlobal -= valorApuesta;
                    valorPerdido += valorApuesta;
                    Console.WriteLine("Perdiste, mejor suerte la proxima");
                }

                Console.WriteLine($"La suma que tiene a dispocision es {valorGlobal} \nLa suma ha ganado hasta el momento es {valorGanado} \nLa suma ha perdido hasta el momento es {valorPerdido}");
                
                Console.WriteLine("Desea seguir jugando?");
                seguir = int.Parse(Console.ReadLine()) == 1;
            } while (seguir);
        }
    }
}
