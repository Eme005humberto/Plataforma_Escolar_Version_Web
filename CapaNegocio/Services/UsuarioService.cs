using CapaNegocio.DTOs;
using CapaNegocio.Models;
using CapaNegocio.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CapaNegocio.Services
{
    /***************************************************************/
    //Desarrollador: Emerson Humberto Carpaño Granados 
    //Fecha: 27/11/2026
    //Clase que contiene los metodos para listar , agregar , modificar , eliminar 
    /**************************************************************/
    public class UsuarioService : IUsuarioService
    {
        private readonly PlataformaEscolarContext _context;

        public UsuarioService(PlataformaEscolarContext context)
        {
            _context = context;
        }
        //********************************************************************
        //Metodo para traer todos los usuarios
        public async Task<List<UsuarioDTO>> AllUser()
        {
            var usuario = await _context.Usuarios.ToListAsync();

            return usuario.Select(u => new UsuarioDTO
            {
                IdUsuario = u.IdUsuario,
                Usuario1 = u.Usuario1,
                Clave = u.Clave,
                IdCargo = u.IdCargo
            }).ToList();
        }
        //*********************************************************************
        public Task<int> DeleteUsuer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDTO> GetUser(int id)
        {
            throw new NotImplementedException();
        }
        /*********************************************************/
        //Metodo para guardar usuarios
        public async Task<int> SaveUser(UsuarioDTO usuarioDTO)
        {
            try
            {
                var usuario = new Usuario
                {
                    Usuario1 = usuarioDTO.Usuario1,
                    Clave = usuarioDTO.Clave,
                    IdCargo = usuarioDTO.IdCargo
                };

                await _context.Usuarios.AddAsync(usuario);
                return await _context.SaveChangesAsync(); //Guardamos los cambios en el contexto de datos

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al guardar el usuario "+ex);
                return 0;
            }
        }
        /********************************************************/
        public Task<int> UpdateUser(UsuarioDTO usuarioDTO, int id)
        {
            throw new NotImplementedException();
        }
    }
}
