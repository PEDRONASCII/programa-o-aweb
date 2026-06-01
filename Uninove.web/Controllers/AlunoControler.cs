using Microsoft.AspNetCore.Mvc;

namespace Uninove.web.Controllers
{
   public class AlunoController : Controller
   {
    
     public ActionResult Index()
     {
        ViewBag.Nome = "Pedro";
        ViewBag.Curso = "Analise de Sistema";
        ViewBag.Semestre ="3";


        return View();
      }
    }  
}
    