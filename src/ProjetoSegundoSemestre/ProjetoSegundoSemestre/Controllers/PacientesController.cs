using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoSegundoSemestre.Data;
using ProjetoSegundoSemestre.Models;

namespace ProjetoSegundoSemestre.Controllers
{
    [Authorize]
    public class PacientesController : Controller
    {
        private readonly ContextDBPriorizandoSaude _context;

        public PacientesController(ContextDBPriorizandoSaude context)
        {
            _context = context;
        }

        // GET: Pacientes
        [Authorize(Roles = "Paciente")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pacientes.ToListAsync());
        }

        // GET: Pacientes/Details/5
        [Authorize(Roles = "Paciente")]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // GET: Pacientes/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("Nome,Senha,Email,Telefone,CPF,Id")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                paciente.Senha = EncriptografarSenha(paciente.Senha);
                _context.Add(paciente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        }



        // GET: Pacientes/Edit/5
        [Authorize(Roles = "Paciente")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Paciente")]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Senha,Email,Telefone,CPF,Id")] Paciente paciente)
        {
            if (id != paciente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    paciente.Senha = EncriptografarSenha(paciente.Senha);
                    _context.Update(paciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteExists(paciente.Id))
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
            return View(paciente);
        }

        // GET: Pacientes/Delete/5
        [Authorize(Roles = "Paciente")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // POST: Pacientes/Delete/5
        [Authorize(Roles = "Paciente")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            _context.Pacientes.Remove(paciente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacienteExists(Guid id)
        {
            return _context.Pacientes.Any(e => e.Id == id);
        }

        #region Login Paciente
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([Bind("Senha,Email")] Paciente pacienteModel)
        {
            var paciente = await _context.Pacientes.Where(x => x.Email == pacienteModel.Email).FirstOrDefaultAsync();

            if (paciente == null)
            {
                ViewBag.Message = "Cadastro não encontrado";
                return View();
            }


            bool senhaOK = BCrypt.Net.BCrypt.Verify(pacienteModel.Senha, paciente.Senha);

            if (senhaOK)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, paciente.Nome),
                    new Claim(ClaimTypes.NameIdentifier, paciente.Email),
                    new Claim(ClaimTypes.Role, "Paciente"),
                    new Claim("Id", paciente.Id.ToString())
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

                return RedirectToAction("Index", "Pacientes");
            }
            else
            {
                ViewBag.Message = "Login e/ou senha incorretos!";
                return View();
            }
        }
        
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }
      
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
        private string EncriptografarSenha(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }
        #endregion
    }
}
