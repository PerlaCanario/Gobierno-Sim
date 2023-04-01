namespace Gobierno_Sim
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Pueblo pueblo = new Pueblo();
            Gobierno gobierno = new Gobierno();
            int numProtestas = 0;
            int numCambiosPolitica = 0;
            int numCambiosGobierno = 0;

            int numCambiosPoliticaTotal = 0;
            int numCambiosGobiernoTotal = 0;

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
                    if (pueblo.EstadoMalestar == Pueblo.NivelMalestar.Alta)
                    {
                        Console.WriteLine("El pueblo está descontento y puede haber protestas.");
                        numProtestas++;
                        Console.WriteLine("Habran cambios.");   
                    }
                    
                }

                // Simulación del comportamiento del gobierno

                gobierno.PartidoPolitico = (gobierno.PartidoPolitico == Gobierno.Partido.Conservador) ?
                            Gobierno.Partido.Liberal : Gobierno.Partido.Conservador;
                numCambiosGobierno++;
                numCambiosGobiernoTotal++;

                gobierno.PoliticaGubernamental = (gobierno.PoliticaGubernamental == Gobierno.Politica.Coercitiva) ?
                    Gobierno.Politica.Permisiva : Gobierno.Politica.Coercitiva;
                numCambiosPolitica++;
                numCambiosPoliticaTotal++;

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