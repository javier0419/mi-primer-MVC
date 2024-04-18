using Microsoft.EntityFrameworkCore;
using mvcProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using mvcProyectoWeb.Data;
using mvcProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoWeb.AccesoDatos.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly ApplicationDbContext _db;
        public ClienteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Cliente cliente)
        {
            var objDesdeDb = _db.Cliente.FirstOrDefault(s => s.Id == cliente.Id);
            objDesdeDb.Nombre = cliente.Nombre;
            objDesdeDb.Paterno = cliente.Paterno;
            objDesdeDb.Materno = cliente.Materno;
            objDesdeDb.Celular = cliente.Celular;
            objDesdeDb.CarnetIdentidad = cliente.CarnetIdentidad;
        }
    }
}
