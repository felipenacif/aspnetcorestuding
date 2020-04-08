using AppStartCMD.Core;
using System.Collections.Generic;
using System.Text;

namespace AppStartCMD.Data
{
    public interface IMateriaData
    {
        IEnumerable<Materia> GetAll();
        Materia GetById(int id);
        Materia Insert(Materia insertedObj);
        Materia Update(Materia updatedObj);
        Materia Delete(int id);
        IEnumerable<Materia> GetMateriaByString(string termo);
        int GetCount();

        int Commit();
    }
}
