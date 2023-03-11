using AppZodiac.Service;
using AppZodiac.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace SignoZodiac_App.Controllers
{
    public class ZodiacoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SignoZodiacoViewModel vm)
        {
            string Resultado = SignoZodiacoService.DeterminarSigno(vm.dia, vm.mes);
            ViewData["message"] = Resultado;
            return View();
        }
    }
}
