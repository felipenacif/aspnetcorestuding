using System.Collections.Generic;
using AppStartCMD.Core;
using System.Linq;

namespace AppStartCMD.Data
{
    public class SqlMateriaData : IMateriaData
    {
        private readonly AppStartCMDDbContext context;

        public SqlMateriaData(AppStartCMDDbContext context)
        {
            this.context = context;
        }

        public int Commit()
        {
            return context.SaveChanges();
        }

        public Materia Delete(int id)
        {
            var materia = GetById(id);
            if(materia != null)
            {
                context.Remove(materia);
            }
            return materia;
        }

        public IEnumerable<Materia> GetAll()
        {
            var query = from e in context.Materias
                        select e;

            return query;
        }

        public Materia GetById(int id)
        {
            return context.Materias.Find(id);
        }

        public int GetCount()
        {
            return context.Materias.Count();
        }

        public IEnumerable<Materia> GetMateriaByString(string termo)
        {
            var query = from e in context.Materias
                        where e.Texto.StartsWith(termo)
                        select e;

            return query;
        }

        public Materia Insert(Materia insertedObj)
        {
            context.Add(insertedObj);
            return insertedObj;
        }

        public Materia Update(Materia updatedObj)
        {
            var entity = context.Materias.Attach(updatedObj);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return updatedObj;
        }
    }
}
