using Portafolio.DataAccess.Repository.IRepository;
using Portafolio.Datos.Data;
using Portafolio.Datos.Repository;
using Portafolio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portafolio.DataAccess.Repository
{
    public class UnidadInternaRepository : Repository<UnidadInterna>, IUnidadInternaRepository
    {
        private readonly ApplicationDbContext _db;

        public UnidadInternaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(UnidadInterna unidadInterna)
        {
            var objFromDb = _db.UnidadInternas.FirstOrDefault(s => s.Id == unidadInterna.Id);
            if (objFromDb != null)
            {
                objFromDb.Des_unidad = unidadInterna.Des_unidad;

            }
        }
    }
}