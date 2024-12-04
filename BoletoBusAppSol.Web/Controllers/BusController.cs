using BoletoBusAppSol.Data.Entities.Configuration;
using BoletoBusAppSol.Data.Interfaces;
using BoletoBusAppSol.Data.Models;
using BoletoBusAppSol.Web.Models.Configuration.Bus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace BoletoBusAppSol.Web.Controllers
{
    public class BusController : Controller
    {
        private readonly IBusRepository _busRepository;

        public BusController(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }
        // GET: BusController
        public async Task<IActionResult> Index()
        {
            var result = await _busRepository.GetAll();

            if (!result.Success)
            {
                ViewBag.Message = result.Message;
                return View();
            }
            List<BusModel>? buses = result.Result;
            return View(buses);
        }

        // GET: BusController/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var result = await _busRepository.GetEntityBy(id);

            if (!result.Success)
            {
                ViewBag.Message = result.Message;
                return View();
            }

            BusModel? buses = result.Result;

            return View(buses);
        }

        // GET: BusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddOrUpdateModel addOrUpdate)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.Message = "Modelo inválido...";
                    return View();
                }

                Bus bus = new Bus()
                {

                    CapacidadPiso1 = addOrUpdate.CapacidadPiso1,
                    CapacidadPiso2 = addOrUpdate.CapacidadPiso2,
                    Disponible = addOrUpdate.Disponible,
                    FechaCreacion = DateTime.Now,
                    Nombre = addOrUpdate.Nombre,
                    NumeroPlaca = addOrUpdate.NumeroPlaca,
                    UsuarioModificacion = 1,
                    FechaModificacion = DateTime.Now,
                };

                var result = await _busRepository.Save(bus);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BusController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _busRepository.GetEntityBy(id);

            if (!result.Success)
            {
                ViewBag.Message = result.Message;
                return View();
            }

            BusModel? buses = result.Result;

            return View(buses);
        }

        // POST: BusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AddOrUpdateModel addOrUpdate)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    ViewBag.Message = "Modelo inválido...";
                    return View();
                }

                Bus bus = new Bus()
                {
                    Id = addOrUpdate.IdBus,
                    CapacidadPiso1 = addOrUpdate.CapacidadPiso1,
                    CapacidadPiso2 = addOrUpdate.CapacidadPiso2,
                    Disponible = addOrUpdate.Disponible,
                    FechaModificacion = DateTime.Now,
                    Nombre = addOrUpdate.Nombre,
                    NumeroPlaca = addOrUpdate.NumeroPlaca,
                    UsuarioModificacion = 1
                };

                var result = await _busRepository.Update(bus);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}
