using ApiExamenServerless.Models;
using ApiExamenServerless.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExamenServerless.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase {
        private RepositoryEventos repo;
        public EventosController(RepositoryEventos repo) {
            this.repo = repo;
        }
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Categoria>> GetCategorias() {
            return this.repo.GetCategorias();
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<Categoria> FindCategoria(int id) {
            return this.repo.FindCategoria(id);
        }
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Evento>> GetEventos() {
            return this.repo.GetEventos();
        }

        [HttpGet]
        [Route("[action]/{idcategoria}")]
        public ActionResult<List<Evento>> GetEventosByCategoria(int idcategoria) {
            return this.repo.GetEventosByCategoria(idcategoria);
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<Evento> FindEvento(int id) {
            return this.repo.FindEvento(id);
        }
        [HttpPost]
        [Route("[action]")]
        public void CreateEvento(Evento evento) {
            this.repo.CreateEvento(evento);
        }
        [HttpDelete]
        [Route("[action]/{id}")]
        public void DeleteEvento(int id) {
            this.repo.DeleteEvento(id);
        }
        [HttpPut]
        [Route("[action]")]
        public void UpdateEventoCategoria(Evento evento) {
            this.repo.UpdateEventoCategoria(evento.IdEvento, evento.IdCategoria);
        }
    }
}
