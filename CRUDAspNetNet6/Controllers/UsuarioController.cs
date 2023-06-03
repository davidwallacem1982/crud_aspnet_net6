using CRUDAspNetNet6.Entities;
using CRUDAspNetNet6.Models;
using CRUDAspNetNet6.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAspNetNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuario;
        public UsuarioController(IUsuarioRepository usuario)
        {
            _usuario = usuario;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> SearchAllUsuarios()
        {
            var result = await _usuario.SelectAllUsuariosAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> SearchUsuarioById(int id)
        {
            var result = await _usuario.SelectUsuarioByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> NewUsuario([FromBody] Usuario model)
        {
            var result = await _usuario.InsertUsuarioAsync(model);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Usuario>>> PutUsuarios([FromBody] UsuarioModel model, int id)
        {
            model.Id = id;
            var result = await _usuario.UpdateUsuarioAsync(id, model);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<List<Usuario>>> DeleteUsuarios(int id)
        {
            var result = await _usuario.DeleteUsuarioAsync(id);
            return Ok(result);
        }
    }
}
