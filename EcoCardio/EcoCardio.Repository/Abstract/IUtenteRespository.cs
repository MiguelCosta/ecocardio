using EcoCardio.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcoCardio.Repository.Abstract
{
    public interface IUtenteRespository : IGenericRepository<Utente>
    {
        Task<IEnumerable<Utente>> Search(string name);
    }
}
