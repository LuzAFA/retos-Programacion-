namespace portafolioC_
{
    internal class Retos8
    {
        /* RETO 8
        ❑ En una competencia de natación se desea implementar una
        aplicación para almacenar el tiempo por cada competidor.
        ❑ Los competidores deben registrarse antes de iniciar la competencia
        con sus nombres
        ❑ Al terminar la carrera se deben registrar los tiempos de cada
        competidor.
        ❑ Muestre en pantalla cada nadador con su respectivo tiempo.
        ❑ Amplíe sus conceptos sobre colecciones en C# y determine de qué
        forma podría determinar quien es el ganador (tenga en cuenta que
        gana quien recorre en menos tiempo la pisicina)
        */
        public static void reto8()
        {
            Console.WriteLine("Cuantas personas van a competir?");
            int cantidadCompetidores = int.Parse(Console.ReadLine());
            String[] nombres = new String[cantidadCompetidores];
            float[] tiempos = new float[cantidadCompetidores];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($" Digite el nombre del competidor {i} ");
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.WriteLine($" Digite el tiempo del competidor {i} ");
                tiempos[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($" Competidor {nombres[i]} con tiempo {tiempos[i]} ");
            }
            int PosicionGanador = 0;
            for (int i = 0; i < tiempos.Length - 1; i++)
            {
                if (tiempos[i] < tiempos[i + 1])
                    PosicionGanador = i;
                else
                    PosicionGanador = i + 1;
            }
            Console.WriteLine($" ..... EL GANADOR ES {nombres[PosicionGanador]} .....  ");
        }
    }
}
