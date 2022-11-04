using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoSegundoSemestre.Data;
using ProjetoSegundoSemestre.Models;

namespace ProjetoSegundoSemestre.Controllers
{
    [Authorize]
    public class ConsultasController : Controller
    {
        private readonly ContextDBPriorizandoSaude _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ConsultasController(ContextDBPriorizandoSaude context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: Consultas
        [Authorize(Roles = "Medico,Paciente")]
        public async Task<IActionResult> Index()
        { 
            var listaConsultas = await _context.Consultas.ToListAsync();
            for (int i = 0; i < listaConsultas.Count; i++)
            {
                listaConsultas[i].Agenda = await _context.Agendas.FindAsync(listaConsultas[i].AgendaId);
            }
            return View(listaConsultas);
        }

        // GET: Consultas/Details/5
        [Authorize(Roles = "Medico,Paciente")]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // GET: Consultas/Create
        [Authorize(Roles = "Paciente")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consultas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Paciente")]
        public async Task<IActionResult> Create(string id)
        {
            if (_httpContextAccessor.HttpContext.User.HasClaim(x => x.Value == "Medico"))
                return View("Index", await _context.Consultas.ToListAsync());
            var consulta = new Consulta();

            consulta.Agenda = _context.Agendas.FirstOrDefault(x => x.Id == new Guid(id));

            consulta.Agenda.StatusAgenda = StatusAgenda.Usado;

            consulta.Status = StatusConsulta.AguardandoConfirmacao;

            var idPaciente = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Id").Value;

            if (consulta.Agenda != null)
            {
                consulta.Paciente = _context.Pacientes.FirstOrDefault(x => x.Id == new Guid(idPaciente));
                if (consulta.Paciente == null)
                    return NotFound();
            }

            _context.Add(consulta);

            var retorno = await _context.SaveChangesAsync();
            if(retorno > 0)
            {
                _context.Update(consulta.Agenda);
                await _context.SaveChangesAsync();
            }
            return View();
        }

        // GET: Consultas/Edit/5
        [Authorize(Roles = "Medico,Paciente")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }
            return View(consulta);
        }

        // POST: Consultas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Medico,Paciente")]
        public async Task<IActionResult> Edit(Guid id, [Bind("Status,Id")] Consulta consulta)
        {
            if (id != consulta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultaExists(consulta.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(consulta);
        }

        // GET: Consultas/Delete/5
        [Authorize(Roles = "Medico,Paciente")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // POST: Consultas/Delete/5
        [Authorize(Roles = "Medico,Paciente")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var consulta = await _context.Consultas.FindAsync(id);
            _context.Consultas.Remove(consulta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultaExists(Guid id)
        {
            return _context.Consultas.Any(e => e.Id == id);
        }
    }
}
