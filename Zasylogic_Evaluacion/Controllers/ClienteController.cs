using Microsoft.AspNetCore.Mvc;
using Zasylogic_Evaluacion.Models;

namespace Zasylogic_Evaluacion.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Listar()
        {
           var listClientes = new[]{
           new ClienteModel { nombre = "Fiorella", apellidos = "Gonzales", celular="923172930" ,email = "f.gonzales@prueba.com", sexo="Mujer", motivo="Incidencia", fecha= DateTime.Parse("01/01/2023 00:00:00") },
           new ClienteModel { nombre = "Isabel", apellidos = "Tamayo", celular="938408432" ,email = "isabel@prueba.com", sexo="Mujer", motivo="Queja", fecha= DateTime.Parse("02/01/2023") },
           new ClienteModel { nombre = "Sofia", apellidos = "Ortega", celular="948408432" ,email = "sOrtega@prueba.com", sexo="Mujer", motivo="Sugerencia", fecha= DateTime.Parse("03/01/2023") },
           new ClienteModel { nombre = "Ricardo", apellidos = "Lopez", celular="958408432" ,email = "lopez@prueba.com", sexo="Hombre", motivo="Reclamacion", fecha= DateTime.Parse("04/01/2023") },
           new ClienteModel { nombre = "Jim", apellidos = "Mejia", celular="978408432" ,email = "jjjj@prueba.com", sexo="Hombre", motivo="Queja", fecha= DateTime.Parse("04/01/2023") },
           new ClienteModel { nombre = "Luis", apellidos = "Toscano", celular="968408432" ,email = "lToscano@prueba.com", sexo="Hombre", motivo="Incidencia", fecha= DateTime.Parse("02/01/2023") }};

           return View(listClientes);
        }

        public IActionResult Registrar()
        {
            return View();
        }
    }
}
