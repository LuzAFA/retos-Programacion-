namespace portafolioC_
{
    internal class Retos1y2
    {
        /* RETO 1
        ¡La abuela tiene horno nuevo! y ha planeado hacer una deliciosa torta de vainilla
        con relleno de crema y fresas.
        La receta dice que debe precalentar el horno a 350 °F (grados Fahrenheit),
        pero su horno muestra la temperatura en °C (grados Centígrados).
        Ayúdale a la abuela a colocar la temperatura correcta.
        Crea un programa en java que convierta grados Fahrenheit (°F) a Centígrados (°C)
        teniendo en cuenta lo siguiente:

        °C=(°F - 32)/1.8

        */
        public static void reto1()
        {
            double gFahrenheit,
                gCentigrados;

            Console.WriteLine("Digite la cantidad de grados Fahrenheit a convertir");
            gFahrenheit = double.Parse(Console.ReadLine());

            gCentigrados = (gFahrenheit - 32) / 1.8;
            Console.WriteLine(
                $"{gFahrenheit} grados Fahrenheit son equivalentes a {gCentigrados} grados Centígrados"
            );
        }

        /* RETO 2
        El centro de salud Famisalud, aplica vacunas a los bebes menores de un año y la dosis a aplicar
        depende del peso y la edad del bebé según la siguiente fórmula:
        dosisVacuna = ((pesoBebe ] 10)/(mesesBebe x 10)) * 8
        Realice un programa en java que le permita a la enfermera, determinar con facilidad la
        dosis de la vacuna que se debe aplicar a un bebé.
        */

        public static void reto2()
        {
            double dosisVacuna,
                pesoBebe,
                mesesBebe;

            Console.WriteLine("Digite el peso del bebe");
            pesoBebe = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la edad del bebe en meses");
            mesesBebe = double.Parse(Console.ReadLine());

            dosisVacuna = ((pesoBebe + 10) / (mesesBebe * 10)) * 8;
            Console.WriteLine($"La dosis que se le debe administrar al bebe es  {dosisVacuna}");
        }
    }
}