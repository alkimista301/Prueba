using Microsoft.AspNetCore.Mvc;
using pruebav1.Models;

namespace pruebav1.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        private IActionResult ObtenerUsuario(Usuario usuario)
        {
            return View(usuario);
        }
    }
}
