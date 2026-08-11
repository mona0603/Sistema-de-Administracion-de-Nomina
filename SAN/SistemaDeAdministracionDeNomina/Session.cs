using SistemaDeAdministracionDeNomina.Entities;

namespace SistemaDeAdministracionDeNomina
{
    internal static class Session
    {
        public static UsersEntity UsuarioLogueado { get; private set; }

        public static void IniciarSesion(UsersEntity usuario)
        {
            UsuarioLogueado = usuario;
        }

        public static void CerrarSesion()
        {
            UsuarioLogueado = null;
        }

        public static bool HaySesionActiva => UsuarioLogueado != null;

        public static bool EsSuperAdmin => UsuarioLogueado?.RoleName == "SUPER_ADMIN";
    }
}