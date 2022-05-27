namespace portafolioC_
{
    internal class Retos3_4y5
    {
        /* RETO 3
        Se pretende construir un programa que simule el juego del carisellazo,
        teniendo en cuenta lo siguiente:

            Se juega contra la máquina
            Se debe simular el lanzamiento de una moneda
            El jugador puede elegir Cara o Sello antes que caiga la moneda
            El juego debe decirle si gana o pierde, gana cuando la moneda coincide con la elección del jugador.

        */

        public static void reto3()
        {
            Random random = new Random();
            int moneda = random.Next(0, 2); // 0 cara 1 sello
            int elecion;

            Console.WriteLine("Digite Su elecion, 1. cara o 2. sello ");
            elecion = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Realizando lanzamiento en 3... 2... 1... ");
            string resultado = moneda == 0 ? "Cara" : "Sello";
            Console.WriteLine($"La moneda ha caido en {resultado}");

            if (moneda == elecion)
                Console.WriteLine("Ganaste");
            else
                Console.WriteLine("Perdiste, mejor suerte la proxima");
        }

        /*RETO 4
        De acuerdo a la sintaxis vista, realice lo siguiente:

        Desarrolle un programa en C# que le permita generar la simulación del
        juego piedra, papel o tijera (juego contra la máquina)
        Determine y muestre en pantalla el resultado del juego, si gana alguien o hay empate.

        */
        public static void reto4()
        {
            Random random = new Random();
            int elecionMaquina = random.Next(0, 3); // 0 piedra, 1 papel, 2 tijera
            string resultadoMaquina =
                elecionMaquina == 0
                    ? "piedra"
                    : elecionMaquina == 1
                        ? "papel"
                        : "tijera";

            Console.WriteLine(
                $"Digite Su elecion, 1. piedra, 2. papel o 3. tijera"
            );
            int elecionUsuario = int.Parse(Console.ReadLine()) - 1;
            string resUsuario =
                elecionUsuario == 0
                    ? "piedra"
                    : elecionUsuario == 1
                        ? "papel"
                        : "tijera";

            Console.WriteLine("1, 2, 3... Piedra papel o tijera... ");
            Console.WriteLine($"La maquina ha sacado {resultadoMaquina}");

            Console.WriteLine($"usuario: {resUsuario} vs maquina: {resultadoMaquina}");
            if (elecionUsuario == elecionMaquina)
                Console.WriteLine($"ES EMPATE");
            else
            {
                switch (elecionUsuario) // 0 piedra, 1 papel, 2 tijera
                {
                    case 0: //piedra
                        if (elecionMaquina == 1)
                            Console.WriteLine($"usuario PIERDE, El papel envuelve a la piedra");
                        else
                            Console.WriteLine($"usuario GANA, La piedra aplasta la tijera");
                        break;

                    case 1: // papel
                        if (elecionMaquina == 0)
                            Console.WriteLine($"usuario GANA, El papel envuelve a la piedra");
                        else
                            Console.WriteLine($"usuario PIERDE, El papel es cortado por la tijera");
                        break;

                    case 2: //tijera
                        if (elecionMaquina == 1)
                            Console.WriteLine($"usuario GANA, El papel es cortado por la tijera");
                        else
                            Console.WriteLine($"usuario PIERDE, La piedra aplasta la tijera");
                        break;
                }
            }
        }

        /* RETO 5
        En Supermercados Noé estamos de aniversario y te obsequiamos
        un descuento en el valor de tu compra, si esta es mayor a 50.000
        y dependiendo de tu suerte:

        Si sacas la bolita roja obtienes 10% en el valor de tu compra
        Si sacas la bolita azul obtienes un 30% en el valor de tu compra
        Si sacas la bolita amarilla obtienes un 50% en el valor de tu compra
        Si sacas la bolita blanca te llevas tu compra gratis

        Permítale a un cliente del supermercado Noé saber si su compra
        ha sido beneficiada con su promoción de aniversario,
        indique acorde a la bolita obtenida de forma aleatoria qué valor
        de descuento ha ganado y cual sería su valor final a pagar.
    */

        public static void reto5()
        {
            Console.WriteLine("Digite el valor la compra");
            float totalCompra = float.Parse(Console.ReadLine());

            float porcentajeDescuento = 0;

            Random random = new Random();
            int bola = random.Next(1, 5);

            float totalConDescuento = 0;

            if (totalCompra >= 50000)
            {
                Console.WriteLine(
                    "Felicidades, has sido seleccionado para participar por nuestro descuento"
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
            {
                Console.WriteLine(
                    "Solo con compras mayores a 50000 puedes participar en nuestra rifa de descuentos"
                );
            }

            Console.WriteLine(
                $"El total que debes pagar de tu compra, es {totalConDescuento} pesos"
            );
        }
    }
}
