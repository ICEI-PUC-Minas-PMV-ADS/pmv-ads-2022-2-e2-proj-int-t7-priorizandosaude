using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ProjetoSegundoSemestre.ViewComponents
{
    public class Menu : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
