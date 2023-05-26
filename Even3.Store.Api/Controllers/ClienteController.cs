using Even3.Store.Api.Models;
using Even3.Store.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Even3.Store.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{

    public ClienteService ClienteService { get; set; }

    public ClienteController(ClienteService clienteService)
    {
        ClienteService = clienteService;
    }

    [HttpGet()]
    public async Task<IActionResult> RetornarTodos()
    {
        var todos = await ClienteService.RetornarTodos();
        return Ok(todos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> RetornarCliente(long id)
    {
        var cliente = await ClienteService.Retornar(id);
        return Ok(cliente);
    }

    [HttpPost]
    public async Task<IActionResult> InserirCliente(Cliente cliente)
    {
        var resultado = await ClienteService.Inserir(cliente);
        return Ok(resultado);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AlterarCliente(int id, Cliente cliente)
    {
        var resultado = await ClienteService.Atualizar(id, cliente);
        return Ok(resultado);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCliente(int id)
    {
        var resultado = await ClienteService.Delete(id);
        return Ok(resultado);
    }
}
