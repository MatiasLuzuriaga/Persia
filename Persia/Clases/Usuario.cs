using System;

namespace Persia
{
	public class Usuario
	{
		private string idFacebook;
		private string nombre;
        private string apellido;
        private bool permisos;

        public string IdFacebook
        {
            get
            {
                return idFacebook;
            }
        }


        public string Nombre {
			get {
				return nombre;
			}
		}

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public bool Permisos
        {
            get
            {
                return permisos;
            }
        }
        

        public Usuario ()
		{
            this.permisos = false;
		}

		public void SetDatos(string idFacebook, string nombre, string apellido)
		{
			this.idFacebook = idFacebook;
			this.nombre = nombre;
			this.apellido = apellido;
			this.permisos = true;
		}
	}
}

