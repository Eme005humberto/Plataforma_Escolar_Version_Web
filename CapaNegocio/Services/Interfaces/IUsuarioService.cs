using CapaNegocio.DTOs;

namespace CapaNegocio.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioDTO> AllUser();
        Task<UsuarioDTO> GetUser(int id);
        Task<int> SaveUser(UsuarioDTO usuarioDTO);
        Task<int> UpdateUser(UsuarioDTO usuarioDTO, int id);
        Task<int> DeleteUsuer(int id);
    }
}
