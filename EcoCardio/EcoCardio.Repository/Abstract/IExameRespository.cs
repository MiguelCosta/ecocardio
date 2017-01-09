using EcoCardio.Domain;
using System.Collections.Generic;

namespace EcoCardio.Repository.Abstract
{
    public interface IExameRespository : IGenericRepository<Exame>
    {
        IEnumerable<Exame> Search(string nome, int numero);
    }
}
