using CapaNegocio.Models;

namespace CapaNegocio.DTOs
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string? Usuario1 { get; set; }

        public string? Clave { get; set; }

        public int? IdCargo { get; set; }

        public virtual Cargo? IdCargoNavigation { get; set; }
    }
}
