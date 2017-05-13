using EcoCardio.Domain;
using EcoCardio.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace EcoCardio.Repository.Implementation
{
    internal class ServicoRespository : GenericRepository<Domain.Servico>, Abstract.IServicoRespository
    {
        private EcoCardioContext _context;

        public ServicoRespository(EcoCardioContext context)
            : base(context)
        {
            _context = context;
        }

        public IEnumerable<Servico> GetByType(ServicoType type)
        {
            var items = _context.Servicos
                .Where(t => t.Tipo == type)
                .OrderBy(t => t.Nome)
                .ToList()
                ;
            return items;
        }
    }
}
