using Domain.Modelos;
using IDYGS102API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDYGS102API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonajeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonajeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<Response<PersonajeResponse>> CrearPersonaje([FromBody] PersonajeResponse i)
        {
            Personaje pers = new Personaje();

            pers.Nombre = i.Nombre;
            pers.Poder = i.Poder;
            pers.Color = i.Color;
            pers.FkGenero = i.FkGenero;

            var result = _context.personajes.Add(pers);
            await _context.SaveChangesAsync();
            return new Response<PersonajeResponse>(i, "agregado");
        }

        [HttpGet]
        public async Task<Response<List<Personaje>>> GetPersonaje()
        {
            var personaje = await _context.personajes.Include(x => x.genero).ToListAsync();

            return new Response<List<Personaje>>(personaje, "obtenido");
        }

        [HttpPut("{id}")]
        public async Task<Response<PersonajeResponse>> Update(int? id, [FromBody] PersonajeResponse request)
        {
            try
            {
                Personaje personaje = new Personaje();

                personaje = _context.personajes.Find(id);

                personaje.Nombre = request.Nombre;
                personaje.Poder = request.Poder;
                personaje.Color = request.Color;
                personaje.FkGenero = request.FkGenero;

                _context.Entry(personaje).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return new Response<PersonajeResponse>(request, "Se actualizo");
            } 
            catch (Exception ex)
            {
                throw new Exception("surgio un error :c" + ex.Message);
            }
        }

    }
}
