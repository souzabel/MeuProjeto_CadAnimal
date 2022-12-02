using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeuProject.Models;
using MeuProject.Repository.Context;

namespace MeuProject.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalRepository animalRepository;
        public AnimalController()
        {
            animalRepository = new AnimalRepository();
        }
        // GET: Animal
        public async Task<IActionResult> Index()
        {
            var listarAnimais = animalRepository.Listar();
            return View(listarAnimais);
        }
    }
}