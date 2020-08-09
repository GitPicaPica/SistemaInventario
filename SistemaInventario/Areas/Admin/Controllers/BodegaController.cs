using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;
using SistemaInventario.Modelos;

namespace SistemaInventario.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BodegaController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public BodegaController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Bodega bodega = new Bodega();
            if(id==null)
            {
                //Esto es para Crear nuevo Registro
                return View(bodega);
            }
            //Esto es para Actualizar
            bodega = _unidadTrabajo.Bodega.Obtener(id.GetValueOrDefault());

            if(bodega ==null)
            {
                return NotFound();
            }
            return View(bodega);
        }
        

        #region API
        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var todos = _unidadTrabajo.Bodega.ObtenerTodos();
            return Json(new { data = todos });
        }

        #endregion
    }
}
