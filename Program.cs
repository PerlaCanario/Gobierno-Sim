namespace Gobierno_Sim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Pueblo pueblo = new Pueblo();
            Gobierno gobierno = new Gobierno();
            int numProtestas = 0;
            int numCambiosPolitica = 0;
            int numCambiosGobierno = 0;

            Console.WriteLine("Presione 'D' para detener la simulación.");
            Console.WriteLine("Comportamiento actual del pueblo: " + pueblo.EstadoMalestar);
            Console.WriteLine("Partido gobernante actual: " + gobierno.PartidoPolitico);
            Console.WriteLine("Estilo de gobernanza actual: " + gobierno.PoliticaGubernamental);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D)
                {
                    break;
                }

                // Simulación del comportamiento del pueblo
                if (pueblo.EstadoMalestar == Pueblo.NivelMalestar.Baja)
                {
                    Console.WriteLine("El pueblo está tranquilo.");
                }
                else
                {
                    Console.WriteLine("El pueblo está descontento y puede haber protestas.");
                    numProtestas++;
                }

                // Simulación del comportamiento del gobierno
                if (gobierno.PoliticaGubernamental == Gobierno.Politica.Permisiva)
                {
                    Console.WriteLine("El gobierno está siendo permisivo.");
                }
                else
                {
                    Console.WriteLine("El gobierno está siendo coercitivo y puede haber cambios.");
                    if (pueblo.EstadoMalestar == Pueblo.NivelMalestar.Alta)
                    {
                        gobierno.PartidoPolitico = (gobierno.PartidoPolitico == Gobierno.Partido.Conservador) ?
                            Gobierno.Partido.Liberal : Gobierno.Partido.Conservador;
                        numCambiosGobierno++;
                    }
                    else
                    {
                        gobierno.PoliticaGubernamental = (gobierno.PoliticaGubernamental == Gobierno.Politica.Coercitiva) ?
                            Gobierno.Politica.Permisiva : Gobierno.Politica.Coercitiva;
                        numCambiosPolitica++;
                    }
                }

                // Actualización del estado de ánimo del pueblo
                Random rnd = new Random();
                pueblo.EstadoMalestar = (rnd.Next(2) == 0) ? Pueblo.NivelMalestar.Baja : Pueblo.NivelMalestar.Alta;

                // Mostrar estados actuales
                Console.WriteLine("Comportamiento actual del pueblo: " + pueblo.EstadoMalestar);
                Console.WriteLine("Partido gobernante actual: " + gobierno.PartidoPolitico);
                Console.WriteLine("Estilo de gobernanza actual: " + gobierno.PoliticaGubernamental);
            }

            // Resumen de la simulación
            Console.WriteLine("\nResumen de la simulación:");
            Console.WriteLine("Número de protestas: " + numProtestas);
            Console.WriteLine("Número de cambios de política: " + numCambiosPolitica);
            Console.WriteLine("Número de cambios de gobierno: " + numCambiosGobierno);
        }
    }
}