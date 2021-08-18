using System;

namespace Veterinaria
{
    class Veterinaria
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* VETERINARIA PET HOUSE *********");

            //Declarar una Mascota
            Mascota Perro = new Mascota("Firulais", "Perro");

            Mascota gato = new Mascota();

            Console.WriteLine("El nombre de la mascota es: " + Perro.Nombre);
            Perro.Nombre = "Dogi";
            Console.WriteLine("El nombre de la mascota es: " + Perro.Nombre);
            Console.WriteLine("La especie de la mascota es: " + Perro.Especie);
        }
    }
}
