using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Cotxe cotxe1 = new Cotxe("Cordoba", "Seat", 2012, 210.0,4);

        // Mostrar la informació del vehicle
        cotxe1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Cotxe cotxe2 = new Cotxe("Ibiza", "Seat", 2017, 170.0,5);
        
        // Mostrar la informació del segon vehicle
        cotxe2.MostrarInformacio();
    }
}
