using System;

namespace ProyectoNetflix
{
    class PeliculasGUI
    {
        
        public void agregar()
        {

            string respues = "", peliculas ="";
            
            Console.WriteLine("Quieres añadir una pelicula?");
            respues = Console.ReadLine();

             if (respues == "Si" || respues == "SI" || respues == "si")
            {
                while (peliculas != "*")
                {
                    Console.WriteLine("Presiona * para terminar");
                    Console.WriteLine("Introduce el nombre de tu pelicula:");
                    peliculas = Console.ReadLine();
                }
            }

        }

    }
}