using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoSegundoSemestre.Data;
using ProjetoSegundoSemestre.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using BCrypt.Net;
using System.Security.Claims;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace ProjetoSegundoSemestre.Controllers
{
    [Authorize]
    public class MedicosController : Controller
    {
        private readonly ContextDBPriorizandoSaude _context;

        public MedicosController(ContextDBPriorizandoSaude context)
        {
            _context = context;
        }

        // GET: Medicos
        [Authorize(Roles = "Medico")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Medicos.ToListAsync());
        }

        // GET: Medicos/Details/5
        [Authorize(Roles = "Medico")]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medico = await _context.Medicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }

            return View(medico);
        }

        // GET: Medicos/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("Nome,Senha,Email,Telefone,Especialidade,CRM,Endereco,Id")] Medico medico)
        {
            if (ModelState.IsValid)
            {
                medico.Senha = EncriptografarSenha(medico.Senha);
                _context.Add(medico);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            return View(medico);
        }


        [Authorize(Roles = "Medico")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medico = await _context.Medicos.FindAsync(id);

            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        [Authorize(Roles = "Medico")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Senha,Email,Telefone,Especialidade,CRM,Endereco,Id")] Medico medico)
        {
            if (id != medico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    medico.Senha = EncriptografarSenha(medico.Senha);
                    _context.Update(medico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicoExists(medico.Id))
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
            return View(medico);
        }

        [Authorize(Roles = "Medico")]
        // GET: Medicos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medico = await _context.Medicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }

            return View(medico);
        }

        [Authorize(Roles = "Medico")]
        // POST: Medicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var medico = await _context.Medicos.FindAsync(id);
            _context.Medicos.Remove(medico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicoExists(Guid id)
        {
            return _context.Medicos.Any(e => e.Id == id);
        }

        #region Login Médico

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([Bind("Senha,Email")] Medico medicoModel)
        {
            var medico = await _context.Medicos.Where(x => x.Email == medicoModel.Email).FirstOrDefaultAsync();

            if (medico == null)
            {
                ViewBag.Message = "Cadastro não encontrado";
                return View();
            }


            bool senhaOK = BCrypt.Net.BCrypt.Verify(medicoModel.Senha, medico.Senha);

            if (senhaOK)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, medico.Nome),
                    new Claim(ClaimTypes.NameIdentifier, medico.Email),
                    new Claim(ClaimTypes.Role, "Medico"),
                    new Claim("Id", medico.Id.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddDays(7),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");
            }
            else
            {
                ViewBag.Message = "Cadastro não encontrado!";
                return View();
            }
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }
        private string EncriptografarSenha(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        #endregion
    }

}
