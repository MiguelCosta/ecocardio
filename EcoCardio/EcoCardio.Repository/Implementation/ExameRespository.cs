using System;
using System.Collections.Generic;
using EcoCardio.Domain;
using System.Linq;

namespace EcoCardio.Repository.Implementation
{
    internal class ExameRespository : GenericRepository<Domain.Exame>, Abstract.IExameRespository
    {
        private EcoCardioContext _context;

        internal ExameRespository(EcoCardioContext context)
           : base(context)
        {
            _context = context;
        }

        public IEnumerable<Exame> Search(string nome, int numero)
        {
            var query = _context.Exames.AsQueryable();

            if (string.IsNullOrWhiteSpace(nome) == false)
            {
                query = query.Where(e => e.Utente.Nome.Contains(nome));
            }

            if (numero > 0)
            {
                query = query.Where(e => e.Numero == numero);
            }

            return query.ToList();
        }
    }
}
