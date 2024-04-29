using System;

namespace ProyectoNetflix
{
    class UsuariosDAO
    {
        
        //constructor
        public UsuariosDAO()
        {

        }
        

        //Declaracion de variables en Get y Set

        //Variables de administrador y usuario
        private string administrador;
        private string contraseña;
       
       //Get y Set de usuario
        public string Administrador 
        {
            get 
            {
                return administrador;
            }
            set
            {
                administrador = value;
            }
        }

        //Get y Set de Contraseña
        public string Contraseña
        {
            get 
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }


    }
}
