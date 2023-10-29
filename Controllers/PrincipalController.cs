using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;


public class PrincipalController : Controller{
    

    [HttpGet]
    [Route("login")]
    public IActionResult Login(string Nombre, string Direccion, string Lenguaje, string Comentario)
    {   
        return View("Formulario");
    }
    [HttpPost]
    [Route("Procesalogin")]
    public IActionResult PostLogin(string Nombre, string Direccion, string Lenguaje, string Comentario)
    {   
        ViewBag.Nombre = Nombre;
        ViewBag.Direccion = Direccion;
        ViewBag.Lenguaje = Lenguaje;
        ViewBag.Comentario = Comentario;


        Console.WriteLine(Nombre);
        Console.WriteLine(Direccion);  
        Console.WriteLine("POSTED");
        return View("RespuestaFormulario");
    }

    [HttpGet]
    [Route("regresar/login")]
    public RedirectToActionResult RegresarLogin(){
        Console.WriteLine("Regresando al login!");
        return RedirectToAction("login");
    }


}
