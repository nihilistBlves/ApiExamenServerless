using ApiExamenServerless.Data;
using ApiExamenServerless.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExamenServerless.Repositories {
    public class RepositoryEventos {
        private EventosContext context;
        public RepositoryEventos(EventosContext context) {
            this.context = context;
        }
        public List<Categoria> GetCategorias() {
            return this.context.Categorias.ToList();
        }
        public Categoria FindCategoria(int id) {
            return this.GetCategorias().SingleOrDefault(x => x.IdCategoria == id);
        }
        public List<Evento> GetEventos() {
            return this.context.Eventos.ToList();
        }
        public Evento FindEvento(int id) {
            return this.GetEventos().SingleOrDefault(x => x.IdEvento == id);
        }
        public List<Evento> GetEventosByCategoria(int idcategoria) {
            return this.GetEventos().Where(x => x.IdCategoria == idcategoria).ToList();
        }
        public void CreateEvento(Evento evento) {
            evento.IdEvento = this.GetMaxIdEvento() + 1;
            this.context.Eventos.Add(evento);
            this.context.SaveChanges();
        }
        public void DeleteEvento(int id) {
            Evento evento = this.FindEvento(id);
            this.context.Eventos.Remove(evento);
            this.context.SaveChanges();
        }
        public void UpdateEventoCategoria(int idevento, int idcategoria) {
            Evento evento = this.context.Eventos.SingleOrDefault(x => x.IdEvento == idevento);
            evento.IdCategoria = idcategoria;
            this.context.SaveChanges();
        }
        private int GetMaxIdEvento() {
            List<Evento> eventosActuales = this.GetEventos();
            int maxId = 0;
            if (eventosActuales.Count != 0) {
                maxId = eventosActuales.Max(x => x.IdEvento);
                return maxId;
            } else {
                return maxId;
            }
        }
    }
}
