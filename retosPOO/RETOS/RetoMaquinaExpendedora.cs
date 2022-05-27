namespace portafolioC_
{
    internal class RetoMaquinaExpendedora
    {
        public static void retoMaquinaExpendedora()
        {
            {
                int fila;
                int columna;
                bool continuar;

                string[,] productos = new string[4, 4];
                int[,] precios = new int[4, 4];

                do
                {
                    Console.WriteLine(
                        "Ingrese la informacion del producto a agregar"
                    );

                    Console.WriteLine("ingrese la fila donde ubicara el producto?");
                    fila = int.Parse(Console.ReadLine());

                    Console.WriteLine("ingrese la columna donde ubicara el producto?");
                    columna = int.Parse(Console.ReadLine());

                    Console.WriteLine(
                        $"Qué producto vas a ingresar en la fila {fila} con columna {columna}?"
                    );
                    productos[fila, columna] = Console.ReadLine();

                    Console.WriteLine(
                        $"Qué precio tiene el producto que ingresaste en la fila {fila} con columna {columna}?"
                    );
                    precios[fila, columna] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Desea ingresar otro producto? 1. SI 2. NO");
                    continuar = int.Parse(Console.ReadLine()) == 1;
                } while (continuar == 1);

                for (int f = 0; f < 4; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        Console.Write($"{productos[f, c]}  -  ");
                    }

                    Console.WriteLine("");

                    for (int c = 0; c < 4; c++)
                    {
                        Console.Write($"{precios[f, c]}  -  ");
                    }

                    Console.WriteLine("");
                }
            }
        }
    }
}
