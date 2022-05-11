using ApiExamenServerless.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExamenServerless.Data {
    public class EventosContext: DbContext {
        public EventosContext(DbContextOptions<EventosContext> options): base(options) { }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Evento> Eventos { get; set; }
    }
}
