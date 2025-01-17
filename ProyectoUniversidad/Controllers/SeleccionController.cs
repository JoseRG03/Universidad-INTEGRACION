﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoUniversidad.Context;
using UniversidadAPI.Models;

namespace ProyectoUniversidad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeleccionController : ControllerBase
    {
        private readonly AppDBContext _context;

        public SeleccionController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Seleccion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seleccion>>> GetSeleccions()
        {
            return await _context.Seleccions.ToListAsync();
        }

        // GET: api/Seleccion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Seleccion>> GetSeleccion(int id)
        {
            var seleccion = await _context.Seleccions.FindAsync(id);

            if (seleccion == null)
            {
                return NotFound();
            }

            return seleccion;
        }

        // PUT: api/Seleccion/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeleccion(int id, Seleccion seleccion)
        {
            if (id != seleccion.seleccion_id)
            {
                return BadRequest();
            }

            _context.Entry(seleccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeleccionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Seleccion
        [HttpPost]
        public async Task<ActionResult<Seleccion>> PostSeleccion(Seleccion seleccion)
        {
            _context.Seleccions.Add(seleccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSeleccion", new { id = seleccion.seleccion_id }, seleccion);
        }

        // DELETE: api/Seleccion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeleccion(int id)
        {
            var seleccion = await _context.Seleccions.FindAsync(id);
            if (seleccion == null)
            {
                return NotFound();
            }

            _context.Seleccions.Remove(seleccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SeleccionExists(int id)
        {
            return _context.Seleccions.Any(e => e.seleccion_id == id);
        }
    }
}
