using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Models;

namespace Travel.Controllers
{
    public class BibliotecaController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Creammos una instancia del data context para poder manejar la conexión a la base de datos
        public readonly applicationDataBaseContext _db;

        //Implementamos el datacontext en el controlador y le asignamos el valor
        public BibliotecaController(applicationDataBaseContext db, ILogger<HomeController> logger)
        {
            _db = db;
            _logger = logger;
        }

        //Traemos la propiedad a utilizar y le damos el valor del data context para recueperar la información
        public IActionResult Index()
        {
            IEnumerable<Detail> details = _db.Details;
            return View(details);
        }
    }
}
