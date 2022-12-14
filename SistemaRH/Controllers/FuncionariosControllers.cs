using Application.Core.Application.Interfaces;
using Application.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;

namespace SistemaRHCompleto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionariosControllers : ControllerBase
    {
        private readonly IFuncionariosApplicationService _funcionariosApplicationService;

        public FuncionariosControllers(IFuncionariosApplicationService funcionariosApplicationService)
        {
            _funcionariosApplicationService = funcionariosApplicationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable> GetAll()
        {
            try
            {
                var response = _funcionariosApplicationService.GetAll();
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{codigo}")]
        public IActionResult Get(Guid codigo)
        {
            try
            {
                var response = _funcionariosApplicationService.Get(codigo);
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{codigo}")]
        public IActionResult Delete(Guid codigo)
        {

            try
            {
                _funcionariosApplicationService.Delete(codigo);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{codigo}")]
        public IActionResult Put(Guid codigo, [FromBody] Funcionario funcionario)
        {
            try
            {
                _funcionariosApplicationService.Update(codigo, funcionario);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Funcionario funcionario)
        {
            try
            {
                var response = _funcionariosApplicationService.Insert(funcionario);
                return Created("Funcionario", response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
