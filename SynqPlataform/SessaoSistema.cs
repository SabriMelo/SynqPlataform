using System;
using System.Collections.Generic;
using System.Text;

namespace SynqPlataform {
    public static class SessaoSistema {
        public static int UsuarioId { get; set; }
        public static string NomeUsuario { get; set; }
        public static string Cargo { get; set; } 
        public static string Equipe { get; set; } = string.Empty;

        public static int EquipeId { get; set; }
        public static bool IsAdmin => Cargo == "Sócio" || Cargo == "Administrador";
    }
}
