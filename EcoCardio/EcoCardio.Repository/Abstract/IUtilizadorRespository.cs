using EcoCardio.Domain;
using System.Threading.Tasks;

namespace EcoCardio.Repository.Abstract
{
    public interface IUtilizadorRespository : IGenericRepository<Utilizador>
    {
        Utilizador FindByUsernameAndPassword(string username, string password);
    }
}
