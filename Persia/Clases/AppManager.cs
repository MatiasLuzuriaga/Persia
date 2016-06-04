using System;

namespace Persia
{
	public class AppManager
	{
		private Usuario usuarioActivo;
        private GestorConsultas gestorConsultas;

		public AppManager ()
		{
            this.gestorConsultas = new GestorConsultas();
        }

		public Usuario ObtenerUsuarioFacebook(string idFacebook, string nombre, string apellido)
		{
            this.gestorConsultas.CrearUsuario(idFacebook, nombre, apellido);
			Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.SetDatos(idFacebook, nombre, apellido);
            this.usuarioActivo = nuevoUsuario;
            return usuarioActivo;
    }

        public Usuario ObtenerUsuarioInvitado()
        {
            return new Usuario();
        }
	}
}

