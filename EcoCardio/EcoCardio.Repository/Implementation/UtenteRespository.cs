using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcoCardio.Domain;

namespace EcoCardio.Repository.Implementation
{
    internal class UtenteRespository : GenericRepository<Domain.Utente>, Abstract.IUtenteRespository
    {
        public UtenteRespository(EcoCardioContext context)
            : base(context)
        {
        }

        public Task<IEnumerable<Utente>> Search(string name)
        {
            throw new NotImplementedException();
        }
    }
}
