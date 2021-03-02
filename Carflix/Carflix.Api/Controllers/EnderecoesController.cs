using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Carflix.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Carflix.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly CarflixContext _context;

        public EnderecoController(CarflixContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Endereco>>> GetAll(int? skip, int? take)
        {
            var enderecos = _context.Endereco.AsQueryable();

            if (skip != null)
            {
                enderecos = enderecos.Skip((int)skip);
            }
            if (take != null)
            {
                enderecos = enderecos.Take((int)take);
            }

            return await enderecos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Endereco>> GetById(int id)
        {
            var endereco = await _context.Endereco.FindAsync(id);

            if (endereco == null)
            {
                return NotFound();
            }

            return endereco;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Endereco endereco)
        {
            if (id != endereco.EnderecoId)
            {
                return BadRequest();
            }

            endereco.DataAtualizacao = DateTime.Now;
            _context.Entry(endereco).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(endereco);
        }

        [HttpPost]
        public async Task<ActionResult<Endereco>> Post(Endereco endereco)
        {
            _context.Endereco.Add(endereco);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAll", new { id = endereco.EnderecoId }, endereco);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Endereco>> Delete(int id)
        {
            var endereco = await _context.Endereco.FindAsync(id);
            if (endereco == null)
            {
                return NotFound();
            }

            _context.Endereco.Remove(endereco);
            await _context.SaveChangesAsync();

            return endereco;
        }

        private bool EnderecoExists(int id)
        {
            return _context.Endereco.Any(e => e.EnderecoId == id);
        }
    }
}
