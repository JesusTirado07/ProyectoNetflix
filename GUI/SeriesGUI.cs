using System;

namespace ProyectoNetflix
{
    class SeriesGUI
    {
        public void agregar()
        {

            string respues = "", seriess ="";
            
            Console.WriteLine("Quieres añadir una series?");
            respues = Console.ReadLine();

            if (respues == "Si" || respues == "SI" || respues == "si")
            {
                while (seriess != "*")
                {
                    Console.WriteLine("Presiona * para terminar");
                    Console.WriteLine("Introduce el nombre de tu serie:");
                    seriess = Console.ReadLine();
                }
            }
        }

    }
}