using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicoController : ControllerBase
{
    IOptions<OpenningTime> _openningTime;

    public MedicoController(IOptions<OpenningTime> openningTime)
    {
        _openningTime = openningTime;
    }
    private static readonly string[] Summaries = new[]
    {
        "Albert", "Pedro", "Maria", "Beatriz", "Joao", "Augusta"
    };

    [HttpGet(Name = "GetMedico")]
    public IEnumerable<Medico> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Medico
        {
            Nome = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Post(Medico medico)
    {
        return CreatedAtRoute("GetMedico", new { id = medico.Id }, medico);
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, Medico medico)
    {
        return Ok();
    }
}
