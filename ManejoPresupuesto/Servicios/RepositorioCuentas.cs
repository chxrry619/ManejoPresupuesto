using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Servicios
{
    public class RepositorioCuentas : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public interface IRepositorioCuentas { }
    }
}
