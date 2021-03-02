using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IpServer.Models;

namespace IpServer.Controllers
{
    public class MarcasController : Controller
    {
        public IActionResult Index()
        {
            List<Marca> list = new List<Marca>();
            list.Add(new Marca { Id = 1, Descricao = "HP" });
            list.Add(new Marca { Id = 2, Descricao = "Dell" });
            return View(list);
        }
    }
}
