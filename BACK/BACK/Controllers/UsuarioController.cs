using System.Collections.Generic;
using BACK.Models;
using Microsoft.AspNetCore.Mvc;

namespace BACK.Controllers
{
    [ApiController]
    [Route("usuario")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarUsuarios()
        {
            return Usuario.usuarios;
                
        }


        [HttpDelete]
        [Route("eliminar")]
        public dynamic eliminarUsuario(Usuario user)
        {
            Usuario.usuarios.RemoveAll(usuario => usuario.user == user.user);
            return new
            {
                success = true,
                message = "Usuario eliminado",
                result = Usuario.usuarios
            };

        }

        [HttpPost]
        [Route("nuevo")]
        public dynamic agregararUsuario(Usuario user)
        {
            Usuario.usuarios.Add(user);
            return new
            {
                success = true,
                message = "Usuario añadido",
                result = Usuario.usuarios
            };

        }

        [HttpPut]
        [Route("editar")]
        public dynamic agregarUsuario(Usuario user)
        {
            Usuario.usuarios.RemoveAll(usuario => usuario.user == user.user);
            Usuario.usuarios.Add(user);
            return new
            {
                success = true,
                message = "Usuario editado",
                result = Usuario.usuarios
            };

        }
    }

    
}
