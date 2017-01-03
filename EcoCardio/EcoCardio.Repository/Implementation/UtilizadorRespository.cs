using EcoCardio.Domain;
using System;
using System.Threading.Tasks;

namespace EcoCardio.Repository.Implementation
{
    internal class UtilizadorRespository : GenericRepository<Domain.Utilizador>, Abstract.IUtilizadorRespository
    {
        public UtilizadorRespository(EcoCardioContext context)
            : base(context)
        {
        }

        public Task<Utilizador> FindByUsernameAndPassword(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
