using EcoCardio.Domain;
using System.Linq;

namespace EcoCardio.Repository.Implementation
{
    internal class UtilizadorRespository : GenericRepository<Domain.Utilizador>, Abstract.IUtilizadorRespository
    {
        private EcoCardioContext _context;

        public UtilizadorRespository(EcoCardioContext context)
            : base(context)
        {
            _context = context;
        }

        public Utilizador FindByUsernameAndPassword(string username, string password)
        {
            return _context.Utilizadores
                .SingleOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
