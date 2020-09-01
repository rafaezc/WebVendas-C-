using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebVendas_C.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Nome"] = "Rafael Estevan Zubiolo Cavalaro";
            ViewData["Numero"] = "2019073845";
            ViewData["Email"] = "r2019073845@edu.faccar.com.br";
            ViewData["Materia"] = "Programação Orientada a Objetos";
            ViewData["AulaSem"] = "um dia, toda Terça-Feira";
            ViewData["Bimestre"] = "3º Bimestre";

            return View();
        }
    }
}
