using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TarefaMVC.Context;
using TarefaMVC.Models;

namespace TarefaMVC.Controllers
{
    public class TarefaController : Controller
    {
        private readonly TarefaContext _context;

        public TarefaController(TarefaContext context){
            _context = context;
        }
        public IActionResult Index(){
            var tarefas = _context.Tarefas.ToList();
            return View(tarefas);
        }
        
        public IActionResult Criar(){
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa){
            if(ModelState.IsValid){
                _context.Tarefas.Add(tarefa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }
    }
}