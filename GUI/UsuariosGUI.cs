using System;

namespace ProyectoNetflix
{
    class UsuariosGUI
    {
        //constructor
        public UsuariosGUI()
        {

        }
        public void usuariocontraseña()
        {
            int opcion;
            int opcion2;
            UsuariosDAO dao = new UsuariosDAO();
            PeliculasGUI pelis = new PeliculasGUI();
            SeriesGUI seriess = new SeriesGUI();

            Console.WriteLine("*****************************************");
            Console.WriteLine("**********BIENVENIDO A NETFLIX***********");
            Console.WriteLine("*****************************************");

            Console.WriteLine("------------------------");
            Console.WriteLine("       QUIEN ERES?");
            Console.WriteLine("------------------------");
            Console.WriteLine("1-ADMINISTRADOR");
            Console.WriteLine("2-USUARIO");
            Console.WriteLine("------------------------");
            Console.WriteLine("Introduce tu opcion");
            Console.WriteLine("------------------------");
            opcion = int.Parse(Console.ReadLine());

            //Selector
            switch (opcion)
            {
                case 1:

                    Console.WriteLine("------------------------");
                    Console.WriteLine("BIENVENIDO ADMINISTRADOR");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Introduce tu usuario");
                    
                    dao.Administrador = Console.ReadLine();

                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Introduce tu contraseña");
                    Console.WriteLine("-----------------------");

                    dao.Contraseña = Console.ReadLine();
                    
                    while (dao.Administrador!="administrador" || dao.Contraseña!="contra")
                    {
                        Console.WriteLine("Usuario o Contraseña incorrecta");
                        Console.WriteLine("Corrije de nuevo los datos");
                        Console.WriteLine("Introduce tu usuario");
                        dao.Administrador = Console.ReadLine();
                        Console.WriteLine("Introduce tu contraseña");
                        dao.Contraseña = Console.ReadLine(); 
                        Console.Clear();
                    }

                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("   Bienvenido Administrador");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("QUE ES LO QUE QUIERES REALIZAR?");
                        Console.WriteLine("1-Agregar pelicula");
                        Console.WriteLine("2-Agregar series");
                        Console.WriteLine("3-Eliminar pelicula");
                        Console.WriteLine("4-Eliminar serie");
                        Console.WriteLine("5-Salir");
                        Console.WriteLine("-------------------------------");
                        opcion2 = int.Parse(Console.ReadLine());

                        switch(opcion2)
                         {
                            case 1:
                            
                            //agregar peliculas
                            pelis.agregar();

                            break;

                            case 2:
                            
                            //agregar series
                            seriess.agregar();

                            break;
                         }
                 
                break;
            }


        }

 
    }
}