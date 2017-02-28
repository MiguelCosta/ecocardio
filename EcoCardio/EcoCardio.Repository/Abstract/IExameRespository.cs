using EcoCardio.Domain;
using System.Collections.Generic;

namespace EcoCardio.Repository.Abstract
{
    public interface IExameRespository : IGenericRepository<Exame>
    {
        IEnumerable<Exame> Search(string nome, int numero, int maxResults = 100);

        IEnumerable<Exame> MostRecent(int maxResults = 100);

        int NextNumber();
    }
}
